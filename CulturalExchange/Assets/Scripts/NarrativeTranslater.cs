using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NarrativeTranslater : MonoBehaviour
{
    public TextManager textHandler;
    public GameObject translaterUIWindow;
    public TextMeshProUGUI translaterText;

    public int translateLimit;
    private int translateCount;

    private bool isOpen;
    private bool foundNothing;
    private bool isAnimating;
    public int targetXpos;
    private RectTransform myRect;

    public Image btnImage;
    public Sprite batteryDead;

    private Coroutine translateRoutine;

    private void Start()
    {
        myRect = GetComponent<RectTransform>();
    }

    public void ToggleTranslater()
    {
        if (!isOpen &&
            translateCount >= translateLimit)
        {
            btnImage.sprite = batteryDead;
            return;
        }

        if(isOpen)
        {
            isOpen = false;
            targetXpos = 410;
            translaterText.text = "";
            if (translateRoutine != null)
            {
                StopCoroutine(translateRoutine);
            }
        }
        else
        {
            isOpen = true;
            targetXpos = 0;

            TryFindTranslateText();
        }

        if(!isAnimating)
        {
            isAnimating = true;
            StartCoroutine(MoveTranslatorUI());
        }
    }

    public void CloseTranslator()
    {
        if(isOpen)
        {
            ToggleTranslater();
        }
    }

    private IEnumerator MoveTranslatorUI()
    {
        while (myRect.anchoredPosition.x != targetXpos)
        {
            float newX = Mathf.Lerp(myRect.anchoredPosition.x, targetXpos, 0.1f);

            if (Mathf.Abs(newX - targetXpos) < 0.2f)
            {
                newX = targetXpos;
            }

            myRect.anchoredPosition = new Vector3(newX, myRect.anchoredPosition.y);

            yield return null;
        }
        isAnimating = false;
        if(foundNothing)
        {
            ToggleTranslater();
            foundNothing = false;
        }
    }

    private void TryFindTranslateText()
    {
        NarrativeBase currentNode = textHandler.GetCurrentNarration();

        if(currentNode.GetType() == typeof(NarrativeTextTranslate))
        {
            TranslateSingle(currentNode as NarrativeTextTranslate);
            translateCount++;
        }
        else if(currentNode.GetType() == typeof(NarrativeTextDecisionsTranslate))
        {
            TranslateChoices(currentNode as NarrativeTextDecisionsTranslate);
            translateCount++;
        }
        else
        {
            ShowNothing();
        }
    }

    private void ShowNothing()
    {
        translaterText.text = "Found nothing to translate";
        foundNothing = true;
    }

    private void TranslateSingle(NarrativeTextTranslate currentNode)
    {
        translaterText.text = currentNode.GetTranslation();
    }

    private void TranslateChoices(NarrativeTextDecisionsTranslate currentNode)
    {
        translateRoutine = StartCoroutine(WriteTranslation(currentNode.GetDecisions()));
        return;
    }

    private IEnumerator WriteTranslation(List<NarrativeDecisionTranslate> gibberishToTranslate)
    {
        while(isAnimating)
        {
            yield return null;
        }

        string workingString = "";

        foreach (NarrativeDecisionTranslate gibberish in gibberishToTranslate)
        {
            int gibberishLenght = gibberish.GetText().Length;

            for (int x = 0; x < gibberishLenght; x++)
            {
                yield return new WaitForSeconds(0.3f);

                workingString += gibberish.GetText()[x];
                translaterText.text = workingString;
            }
            yield return new WaitForSeconds(0.3f);

            workingString += ": ";
            workingString += gibberish.GetTranslation();
            workingString += "\n";
            translaterText.text = workingString;
        }
    }
}
