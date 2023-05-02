using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class DialogueChoiceTranslate : MonoBehaviour
{
    [SerializeField]
    TextAsset ChoiceText;

    [SerializeField]
    TextAsset TranslatedText;

    public string GetText()
    {
        return ChoiceText.text;
    }

    public string GetTranslation()
    {
        return TranslatedText.text;
    }
}
