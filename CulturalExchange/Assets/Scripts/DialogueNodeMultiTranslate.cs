using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class DialogueNodeMultiTranslate : DialogueNode
{
    [SerializeField]
    TextAsset ChoicePrompt;

    [SerializeField]
    List<DialogueChoiceTranslate> Choices;

    [SerializeField]
    List<DialogueNode> NextNodes;

    public override void OpenNode(TextBoxHandler textHandler)
    {
        Debug.Log("Opening multi node");
        RunNodeEvent();
        textHandler.SetChoiceDialogueTranslate(this);
    }

    public override string GetText()
    {
        return ChoicePrompt.text;
    }

    public List<DialogueChoiceTranslate> GetChoices()
    {
        return Choices;
    }

    public DialogueNode GetChoiceNode(int index)
    {
        return NextNodes[index];
    }

    public int GetCount()
    {
        return Choices.Count;
    }
}
