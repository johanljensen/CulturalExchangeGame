using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class DialogueNodeMultiTranslate : DialogueNodeMulti
{
    [SerializeField]
    List<DialogueChoiceTranslate> Choices;

    public List<DialogueChoiceTranslate> GetChoicesTranslate()
    {
        return Choices;
    }
}
