using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Serialization;

public class NarrativeDecisionTranslate : MonoBehaviour
{
    [SerializeField]
    TextAsset decisionTextFile;

    [SerializeField]
    TextAsset translatedTextFile;

    public string GetText()
    {
        return decisionTextFile.text;
    }

    public string GetTranslation()
    {
        return translatedTextFile.text;
    }
}
