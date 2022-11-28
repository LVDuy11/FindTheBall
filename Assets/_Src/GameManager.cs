using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score = 0;

    private void Start()
    {
        UIManager.instance.SetScoreTxt("Score: "+ score);
    }

    public int Score { get => score; set => score=value; }

    public virtual void RePlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        UIManager.instance.ShowWinGame(false);
        UIManager.instance.ShowGameOver(false);
    }

    public virtual void IncrementScore()
    {
        score++;
        UIManager.instance.SetScoreTxt("Score: " + score);
    }
}
