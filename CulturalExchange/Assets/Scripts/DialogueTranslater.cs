using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueTranslater : MonoBehaviour
{
    public TextBoxHandler textHandler;
    public GameObject translaterUIWindow;
    public TextMeshProUGUI translaterText;

    public void ToggleTranslater()
    {
        Debug.Log("Hello world");
        translaterUIWindow.SetActive(!translaterUIWindow.activeSelf);

        if(translaterUIWindow.activeSelf)
        {
            TryFindTranslateText();
        }
    }

    private void TryFindTranslateText()
    {
        DialogueNode currentNode = textHandler.GetCurrentNode();

        if(currentNode.GetType() == typeof(DialogueNodeSingleTranslate))
        {
            TranslateSingle(currentNode as DialogueNodeSingleTranslate);
        }
        else if(currentNode.GetType() == typeof(DialogueNodeMultiTranslate))
        {
            TranslateChoices(currentNode as DialogueNodeMultiTranslate);
        }
        else
        {
            ShowNothing();
        }
    }

    private void ShowNothing()
    {

    }

    private void TranslateSingle(DialogueNodeSingleTranslate currentNode)
    {
        translaterText.text = currentNode.GetTranslation();
    }

    private void TranslateChoices(DialogueNodeMultiTranslate currentNode)
    {
        string translateString = "";

        foreach (DialogueChoiceTranslate choice in currentNode.GetChoices())
        {
            translateString += choice.GetTranslation();
        }

        translaterText.text = translateString;
    }
}
