using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueNodeEndScene : DialogueNode
{
    public override void OpenNode(TextBoxHandler textHandler)
    {
        SceneManager.LoadScene("HomeScene");
    }
}
