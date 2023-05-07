using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class DialogueNodeMulti : DialogueNode
{
    [SerializeField]
    TextAsset ChoicePrompt;

    [SerializeField]
    List<DialogueChoice> Choices;

    [SerializeField]
    List<DialogueNode> NextNodes;

    public override void OpenNode(TextBoxHandler textHandler)
    {
        Debug.Log("Opening multi node");
        RunNodeEvent();
        textHandler.SetChoiceDialogue(this);
    }

    public override string GetText()
    {
        return ChoicePrompt.text;
    }

    public virtual List<DialogueChoice> GetChoices()
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
