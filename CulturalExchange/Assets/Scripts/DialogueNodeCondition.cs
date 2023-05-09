using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueNodeCondition : DialogueNode
{
    [SerializeField]
    TextAsset DialogueText;

    [SerializeField]
    DialogueNode defaultNode;
    [SerializeField]
    DialogueNode conditionalNode;

    [SerializeField]
    NarrativeStates.StoryStates Condition;

    public override void OpenNode(TextBoxHandler textHandler)
    {
        Debug.Log("Opening condition node");
        RunNodeEvent();
        textHandler.SetSimpleDialogue(this);
    }
    public override string GetText()
    {
        return DialogueText.text;
    }

    public override DialogueNode GetNextNode()
    {
        NarrativeStates states = FindObjectOfType<NarrativeStates>();
        if (states != null)
        {
            if (states.IsStateChecked(Condition))
            {
                return conditionalNode;
            }
        }

        return defaultNode;
    }
}