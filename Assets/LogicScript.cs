using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreUpSound;
    public AudioSource gameOverSound;
    public int countGameOverCollision=0;


   // [ContextMenu("Increase Score")]

    public void addScore(int scoreToAdd)
    {
        playerScore=playerScore+scoreToAdd;
        scoreText.text=playerScore.ToString();
        scoreUpSound.Play();

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        countGameOverCollision++;
        if(countGameOverCollision==1)
        {
            gameOverSound.Play();
        }
        gameOverScreen.SetActive(true);

        playerScore=-1;
    }
}
