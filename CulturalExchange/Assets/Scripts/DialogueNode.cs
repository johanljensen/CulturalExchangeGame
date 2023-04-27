using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class DialogueNode : MonoBehaviour
{
    [SerializeField]
    UnityEvent NodeEvent;

    public abstract void OpenNode(TextBoxHandler textHandler);

    public virtual string GetText() { return null; }
    public virtual DialogueNode GetNextNode() { return null; }

    internal void RunNodeEvent()
    {
        NodeEvent.Invoke();
    }
}
