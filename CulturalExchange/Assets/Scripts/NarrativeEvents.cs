using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeEvents : MonoBehaviour
{
    [SerializeField]
    NarrativeStates States;

    private void Start()
    {
        if (States == null)
        {
            States = FindObjectOfType<NarrativeStates>();
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
