using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryEvents : MonoBehaviour
{
    [SerializeField]
    StoryStates States;

    private void Start()
    {
        if (States == null)
        {
            States = FindObjectOfType<StoryStates>();
        }
    }

    public void SetStateCorrectMilk()
    {
        States.ChoseCorrectMilk();
    }

    public void SetStateCorrectBread()
    {
        States.ChoseCorrectBread();
    }

    public void SetStateCorrectMeat()
    {
        States.ChoseCorrectMeat();
    }
}
