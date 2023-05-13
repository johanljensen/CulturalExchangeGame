using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void OpenStoreScene()
    {
        SceneManager.LoadScene("GroceryStoreScene");
    }

    public void OpenBarScene()
    {
        SceneManager.LoadScene("PartyBarScene");
    }

    public void OpenSchoolScene()
    {
        SceneManager.LoadScene("SchoolScene");
    }

    public void UnityQuit()
    {
        Application.Quit();
    }
}
