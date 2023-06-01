using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Serialization;

public class NarrativeDecision : MonoBehaviour
{
    [SerializeField]
    TextAsset decisionTextFile;


    public string DecisionText()
    {
        return decisionTextFile.text;
    }
}
