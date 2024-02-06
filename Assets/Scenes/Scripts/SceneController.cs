using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void NextSceneIndex(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void NextSceneName(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
