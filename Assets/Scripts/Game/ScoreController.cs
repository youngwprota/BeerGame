using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    void Update()
    {
        DrawScore();
        if (Score.playerScore == 6) PlayerWin();
        if (Score.botScore == 6) BotWin();
    }

    void DrawScore()
    {
        scoreText.text = Score.playerScore.ToString() + " : " + Score.botScore.ToString();
    }

    public void PlayerWin()
    {
        ClearScore();
        SceneManager.LoadScene("PlayerWin");
    }
    public void BotWin()
    {
        ClearScore();
        SceneManager.LoadScene("MainMenu");
    }

    public void ClearScore()
    {
        Score.playerScore = 0;
        Score.botScore = 0;
    }
}
