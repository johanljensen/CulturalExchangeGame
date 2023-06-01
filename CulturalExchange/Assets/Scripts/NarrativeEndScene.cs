using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NarrativeEndScene : NarrativeBase
{
    public override void AdvanceNarrative(TextManager textHandler)
    {
        SceneManager.LoadScene("HomeScene");
    }
}
