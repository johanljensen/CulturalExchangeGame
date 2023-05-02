using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeStates : MonoBehaviour
{
    public enum StoryStates
    {
        None,
        CorrectMilk,
        CorrectBread,
        CorrectMeat
    }

    [SerializeField]
    List<StoryStates> CheckedStates;

    public void ChoseCorrectMilk()
    {
        CheckedStates.Add(StoryStates.CorrectMilk);
    }

    public void ChoseCorrectBread()
    {
        CheckedStates.Add(StoryStates.CorrectBread);
    }
    public void ChoseCorrectMeat()
    {
        CheckedStates.Add(StoryStates.CorrectMeat);
    }

    public bool IsStateChecked(StoryStates state)
    {
        if (state == StoryStates.None)
        {
            return true;
        }

        return CheckedStates.Contains(state);
    }
}
