using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class NarrativeTextDecisionsTranslate : NarrativeBase
{
    [SerializeField]
    TextAsset DecisionPrompt;

    [SerializeField]
    List<NarrativeDecisionTranslate> Decisions;

    [SerializeField]
    List<NarrativeBase> NextNarratives;

    public override void AdvanceNarrative(TextManager textHandler)
    {
        Debug.Log("Opening multi node");
        RunNarrativeEvent();
        textHandler.SetDecisionTranslate(this);
    }

    public override string GetText()
    {
        return DecisionPrompt.text;
    }

    public List<NarrativeDecisionTranslate> GetDecisions()
    {
        return Decisions;
    }

    public NarrativeBase GetDecisionNext(int index)
    {
        return NextNarratives[index];
    }
}
