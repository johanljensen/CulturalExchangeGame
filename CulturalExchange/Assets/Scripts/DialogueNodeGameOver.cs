using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNodeGameOver : DialogueNode
{
    public override void OpenNode(TextBoxHandler textHandler)
    {
        Debug.Log("Opening game over node");
        textHandler.DisplayGameOver();
    }
}
