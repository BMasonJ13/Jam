using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuSceneManager : MonoBehaviour
{
    public void NextScene(string sceneName)
    { 
        SceneManager.LoadScene(sceneName);
    }

    public void ExitApp()
    { 
        Application.Quit();
    }
}
