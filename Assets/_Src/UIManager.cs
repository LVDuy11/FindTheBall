using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    static public UIManager instance;

    public Text score;
    public GameObject gameOver;
    public GameObject winGame;

    private void Awake()
    {
        UIManager.instance = this;
    }
    public virtual void SetScoreTxt(string txt)
    {
        if (score)
            score.text = txt;
    }

    public virtual void ShowGameOver(bool isShow)
    {
        if (gameOver)
            gameOver.SetActive(isShow);
    }

    public virtual void ShowWinGame(bool isShow)
    {
        if (winGame)
            winGame.SetActive(isShow);
    }
}
