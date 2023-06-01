using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class NarrativeTextTranslate : NarrativeBase
{
    [SerializeField]
    [FormerlySerializedAs("DialogueText")] TextAsset narrativeText;

    [SerializeField]
    TextAsset TranslatedText;

    [SerializeField]
    [FormerlySerializedAs("NextNode")] private NarrativeBase NextNarrative;

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

    public string GetTranslation()
    {
        return TranslatedText.text;
    }

    public override NarrativeBase GetNextNarrative()
    {
        return NextNarrative;
    }
}
