using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeStates : MonoBehaviour
{
    public enum StoryStates
    {
        None,
        HurtLegHelped,
        CryingGirlHelped
    }

    [SerializeField]
    List<StoryStates> CheckedStates;

    public void HelpedHurtLeg()
    {
        CheckedStates.Add(StoryStates.HurtLegHelped);
    }

    public void HelpedCryingGirl()
    {
        CheckedStates.Add(StoryStates.CryingGirlHelped);
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
