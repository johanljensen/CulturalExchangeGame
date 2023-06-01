using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryStates : MonoBehaviour
{
    public enum StoryState
    {
        None,
        CorrectMilk,
        CorrectBread,
        CorrectMeat,
        AllCorrectGroceries
    }

    [SerializeField]
    List<StoryState> CheckedStates;

    public void ChoseCorrectMilk()
    {
        CheckedStates.Add(StoryState.CorrectMilk);
        CheckCorrectGroceries();
    }

    public void ChoseCorrectBread()
    {
        CheckedStates.Add(StoryState.CorrectBread);
        CheckCorrectGroceries();
    }
    public void ChoseCorrectMeat()
    {
        CheckedStates.Add(StoryState.CorrectMeat);
        CheckCorrectGroceries();
    }

    private void CheckCorrectGroceries()
    {
        if (IsStateChecked(StoryState.CorrectMilk) &&
            IsStateChecked(StoryState.CorrectBread) &&
            IsStateChecked(StoryState.CorrectMeat))
        {
            CheckedStates.Add(StoryState.AllCorrectGroceries);
        }
    }

    public bool IsStateChecked(StoryState state)
    {
        if (state == StoryState.None)
        {
            return true;
        }

        return CheckedStates.Contains(state);
    }
}
