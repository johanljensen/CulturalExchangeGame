using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NarrativeTextConditionSplit : NarrativeBase
{
    [SerializeField]
    TextAsset DialogueText;

    [SerializeField]
    List<NarrativeBase> NextNodes;

    [SerializeField]
    List<StoryStates.StoryState> Conditions;

    public override void AdvanceNarrative(TextManager textHandler)
    {
        Debug.Log("Opening split item node");
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
