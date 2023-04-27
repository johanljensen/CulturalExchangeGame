using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class DialogueChoice : MonoBehaviour
{
    [SerializeField]
    TextAsset ChoiceText;


    public string GetText()
    {
        return ChoiceText.text;
    }
}
