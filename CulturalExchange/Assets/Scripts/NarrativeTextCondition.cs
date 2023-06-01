using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NarrativeTextCondition : NarrativeBase
{
    [SerializeField]
    TextAsset DialogueText;

    [SerializeField]
    NarrativeBase defaultNode;
    [SerializeField]
    NarrativeBase conditionalNode;

    [SerializeField]
    StoryStates.StoryState Condition;

    public override void AdvanceNarrative(TextManager textHandler)
    {
        Debug.Log("Opening condition node");
        RunNarrativeEvent();
        textHandler.SetNarration(this);
    }
    public override string GetText()
    {
        return DialogueText.text;
    }

    public override NarrativeBase GetNextNarrative()
    {
        StoryStates states = FindObjectOfType<StoryStates>();
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