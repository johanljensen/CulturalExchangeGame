using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNodeSingle : DialogueNode
{
    [SerializeField]
    TextAsset DialogueText;

    [SerializeField]
    private DialogueNode NextNode;

    public override void OpenNode(TextBoxHandler textHandler)
    {
        Debug.Log("Opening single node");
        RunNodeEvent();
        textHandler.SetSimpleDialogue(this);
    }

    public override string GetText()
    {
        return DialogueText.text; 
    }

    public override DialogueNode GetNextNode()
    {
        return NextNode;
    }
}
