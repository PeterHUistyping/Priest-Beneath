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
    public int wall_reference_hp;
    public int bullet_reference_damage;
    public double bullet_frequency;
    public double wall_move_speed;

    [ContextMenu("Increase Score")]
    public void addScore1(int scoreToadd)
    {
        playerScore += scoreToadd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
