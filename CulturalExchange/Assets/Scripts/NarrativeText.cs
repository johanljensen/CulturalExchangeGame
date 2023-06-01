using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class NarrativeText : NarrativeBase
{
    [SerializeField]
    TextAsset narrativeText;

    [SerializeField]
    private NarrativeBase NextNarrative;

    public override void AdvanceNarrative(TextManager textHandler)
    {
        Debug.Log("Opening single node");
        RunNarrativeEvent();
        textHandler.SetNarration(this);
    }

    public override string GetText()
    {
        return narrativeText.text; 
    }

    public override NarrativeBase GetNextNarrative()
    {
        return NextNarrative;
    }
}
