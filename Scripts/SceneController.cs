using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    GameController gameController;
    public string sceneName;

    private void Awake()
    {
        gameController = Object.FindObjectOfType<GameController>();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Play()
    {
        SceneManager.LoadScene(sceneName);
    }

}
