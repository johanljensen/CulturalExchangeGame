using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNodeSingleTranslate : DialogueNode
{
    [SerializeField]
    TextAsset DialogueText;

    [SerializeField]
    TextAsset TranslatedText;

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

    public string GetTranslation()
    {
        return TranslatedText.text;
    }

    public override DialogueNode GetNextNode()
    {
        return NextNode;
    }
}
