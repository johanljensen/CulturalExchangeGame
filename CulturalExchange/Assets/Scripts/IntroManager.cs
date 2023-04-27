using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    [SerializeField]
    int currentTextNumber = 0;

    [SerializeField]
    List<TextMeshProUGUI> introTexts;

    private void Start()
    {
        foreach(TextMeshProUGUI textMeshProUGUI in introTexts)
        {
            textMeshProUGUI.enabled = false;
            textMeshProUGUI.gameObject.SetActive(false);
        }
        introTexts[0].enabled = true;
        introTexts[0].gameObject.SetActive(true);
    }

    public void GoNext()
    {
        currentTextNumber++;

        if (currentTextNumber == introTexts.Count)
        {
            GoToRoomScene();
        }
        else
        {
            introTexts[currentTextNumber].enabled = true;
            introTexts[currentTextNumber].gameObject.SetActive(true);
            introTexts[currentTextNumber - 1].enabled = false;
            introTexts[currentTextNumber - 1].gameObject.SetActive(false);
        }
    }

    public void GoBack()
    {

        if(currentTextNumber == 0)
        {
            return;
        }

        currentTextNumber--;

        introTexts[currentTextNumber].enabled = true;
        introTexts[currentTextNumber].gameObject.SetActive(true);
        introTexts[currentTextNumber + 1].enabled = false;
        introTexts[currentTextNumber + 1].gameObject.SetActive(false);
    }

    void GoToRoomScene()
    {
        SceneManager.LoadScene("Room");
    }
}
