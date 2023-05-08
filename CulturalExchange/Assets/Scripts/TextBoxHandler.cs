using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxHandler : MonoBehaviour
{
    public GameObject SimpleDialogue;
    public TextMeshProUGUI SimpleDialogueText;
    public Button SimpleDialogueButton;


    public GameObject ChoiceDialogue;
    public TextMeshProUGUI ChoiceDialoguePrompt;
    public List<TextMeshProUGUI> ChoiceTexts;
    public List<Button> ChoiceButtons;

    private DialogueNode currentNode;
    public DialogueNode GetCurrentNode() { return currentNode; }

    private void SetActiveStates(bool isMultiChoice)
    {
        SimpleDialogue.SetActive(!isMultiChoice);
        ChoiceDialogue.SetActive(isMultiChoice);

        foreach(TextMeshProUGUI text in ChoiceTexts)
        {
            text.gameObject.SetActive(false);
        }
    }

    public void SetSimpleDialogue(DialogueNode nodeSingle)
    {
        currentNode = nodeSingle;
        Debug.Log("Setting single node");
        SetActiveStates(false);

        SimpleDialogueText.text = nodeSingle.GetText();
        SimpleDialogueButton.onClick.RemoveAllListeners();
        SimpleDialogueButton.onClick.AddListener(() => nodeSingle.GetNextNode().OpenNode(this));
    }

    public void SetChoiceDialogue(DialogueNodeMulti nodeMulti)
    {
        currentNode = nodeMulti;
        Debug.Log("Setting multi node");
        SetActiveStates(true);

        ChoiceDialoguePrompt.text = nodeMulti.GetText();

        List<DialogueChoice> choices = nodeMulti.GetChoices();
        for (int x = 0; x < choices.Count; x++)
        {
            int CurrentIndex = x;
            ChoiceTexts[x].gameObject.SetActive(true);
            ChoiceTexts[x].text = choices[x].GetText();
            ChoiceButtons[x].onClick.RemoveAllListeners();
            ChoiceButtons[x].onClick.AddListener(() => nodeMulti.GetChoiceNode(CurrentIndex).OpenNode(this));
        }
    }

    public void SetChoiceDialogueTranslate(DialogueNodeMultiTranslate nodeMulti)
    {
        currentNode = nodeMulti;
        Debug.Log("Setting multi node");
        SetActiveStates(true);

        ChoiceDialoguePrompt.text = nodeMulti.GetText();

        List<DialogueChoiceTranslate> choices = nodeMulti.GetChoices();
        for (int x = 0; x < choices.Count; x++)
        {
            int CurrentIndex = x;
            ChoiceTexts[x].gameObject.SetActive(true);
            ChoiceTexts[x].text = choices[x].GetText();
            ChoiceButtons[x].onClick.RemoveAllListeners();
            ChoiceButtons[x].onClick.AddListener(() => nodeMulti.GetChoiceNode(CurrentIndex).OpenNode(this));
        }
    }
}
