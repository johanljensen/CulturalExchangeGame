using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueNodeSplitCondition : DialogueNode
{
    [SerializeField]
    TextAsset DialogueText;

    [SerializeField]
    List<DialogueNode> NextNodes;

    [SerializeField]
    List<NarrativeStates.StoryStates> Conditions;

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
        NarrativeStates states = FindObjectOfType<NarrativeStates>();
        if (states != null)
        {
            for (int x = 0; x < NextNodes.Count; x++)
            {
                if (states.IsStateChecked(Conditions[x]))
                {
                    return NextNodes[x];
                }
            }
        }

        return null;
    }
}
