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
        CorrectMeat,
        AllCorrectGroceries
    }

    [SerializeField]
    List<StoryStates> CheckedStates;

    public void ChoseCorrectMilk()
    {
        CheckedStates.Add(StoryStates.CorrectMilk);
        CheckCorrectGroceries();
    }

    public void ChoseCorrectBread()
    {
        CheckedStates.Add(StoryStates.CorrectBread);
        CheckCorrectGroceries();
    }
    public void ChoseCorrectMeat()
    {
        CheckedStates.Add(StoryStates.CorrectMeat);
        CheckCorrectGroceries();
    }

    private void CheckCorrectGroceries()
    {
        if (IsStateChecked(StoryStates.CorrectMilk) &&
            IsStateChecked(StoryStates.CorrectBread) &&
            IsStateChecked(StoryStates.CorrectMeat))
        {
            CheckedStates.Add(StoryStates.AllCorrectGroceries);
        }
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
