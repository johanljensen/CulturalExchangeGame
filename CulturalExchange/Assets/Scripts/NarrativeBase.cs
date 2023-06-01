using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public abstract class NarrativeBase : MonoBehaviour
{
    [SerializeField]
    UnityEvent NarrativeEvent;

    public abstract void AdvanceNarrative(TextManager textHandler);

    public virtual string GetText() { return null; }
    public virtual NarrativeBase GetNextNarrative() { return null; }

    internal void RunNarrativeEvent()
    {
        NarrativeEvent.Invoke();
    }
}
