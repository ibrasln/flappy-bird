using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    [SerializeField]
    TMP_Text scoreText, scoreGameOverText;
    [SerializeField]
    Button pauseButton, resumeButton;
    [SerializeField]
    GameObject gameOverPanel;
    [SerializeField]
    Sprite bronzeMedal, silverMedal, goldMedal;
    [SerializeField]
    Image medal;

    // Start is called before the first frame update
    void Start()
    {
        print("Started!");
        scoreText.text = 0.ToString();
        scoreGameOverText.text = 0.ToString();
        gameOverPanel.gameObject.SetActive(false);
        medal.sprite = null;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();

        if (BirdController.isDead)
        {
            Medal();
            GameOver();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void UpdateScore()
    {
        scoreText.text = BirdController.score.ToString();
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseButton.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        resumeButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        scoreGameOverText.text = BirdController.score.ToString();
    }

    public void ResetGame()
    {
        medal.sprite = null;
        gameOverPanel.SetActive(false);
        BirdController.score = 0;
    }

    public void Medal()
    {
        if(BirdController.score < 5)
        {
            medal.sprite = bronzeMedal;
        }
        else if(BirdController.score >= 5 && BirdController.score < 15)
        {
            medal.sprite = silverMedal;
        }
        else
        {
            medal.sprite = goldMedal;
        }
    }

}
