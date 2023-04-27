using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeInitiator : MonoBehaviour
{
    [SerializeField]
    TextBoxHandler textBoxHandler;

    [SerializeField]
    DialogueNodeSingle firstDialogue;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        firstDialogue.OpenNode(textBoxHandler);
    }
}
