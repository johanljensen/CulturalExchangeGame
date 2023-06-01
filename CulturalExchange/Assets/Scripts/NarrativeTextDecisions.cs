using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class NarrativeTextDecisions : NarrativeBase
{
    [SerializeField]
    TextAsset DecisionPrompt;

    [SerializeField]
    List<NarrativeDecision> Decisions;

    [SerializeField]
    List<NarrativeBase> NextNarratives;

    public override void AdvanceNarrative(TextManager textHandler)
    {
        Debug.Log("Opening multi node");
        RunNarrativeEvent();
        textHandler.SetDecision(this);
    }

    public override string GetText()
    {
        return DecisionPrompt.text;
    }

    public virtual List<NarrativeDecision> GetDecisions()
    {
        return Decisions;
    }

    public NarrativeBase GetDecisionNarrative(int index)
    {
        return NextNarratives[index];
    }

    public int GetCount()
    {
        return Decisions.Count;
    }
}
