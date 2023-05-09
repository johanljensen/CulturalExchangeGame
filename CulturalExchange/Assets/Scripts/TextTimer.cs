using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextTimer : MonoBehaviour
{
    public TextMeshProUGUI myTimerString;
    public TextMeshProUGUI myTimerText;

    public void SetTimerStringText(string text)
    {
        myTimerString.text = text;
    }

    public void SetTimerText(string text)
    {
        myTimerText.text = text;
    }
}
