using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void QuiteGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
