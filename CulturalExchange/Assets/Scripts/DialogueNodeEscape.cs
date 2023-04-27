using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueNodeEscape : DialogueNode
{
    public override void OpenNode(TextBoxHandler textHandler)
    {
        Debug.Log("Opening game over node");
        textHandler.DisplayEscape();
    }
}
