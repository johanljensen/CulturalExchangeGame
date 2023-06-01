using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryStarter : MonoBehaviour
{
    [SerializeField]
    TextManager textBoxHandler;

    [SerializeField]
    NarrativeText firstDialogue;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        firstDialogue.AdvanceNarrative(textBoxHandler);
    }
}
