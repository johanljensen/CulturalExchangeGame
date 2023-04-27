using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNodeSplitItem : DialogueNode
{
    [SerializeField]
    TextAsset DialogueText;

    [SerializeField]
    DialogueNode NextNodeIfHasItem;
    [SerializeField]
    DialogueNode NextNodeIfNoItem;

    public override void OpenNode(TextBoxHandler textHandler)
    {
        Debug.Log("Opening split item node");
        RunNodeEvent();
        textHandler.SetSimpleDialogue(this);
    }

    public override string GetText()
    {
        return DialogueText.text;
    }

    public override DialogueNode GetNextNode()
    {
        if (true)
        {
            return NextNodeIfHasItem;
        }
        return NextNodeIfNoItem;
    }
}
