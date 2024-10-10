using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    void Update()
    {
        DrawScore();
    }

    void DrawScore()
    {
        scoreText.text = Score.playerScore.ToString() + " : " + Score.botScore.ToString();
    }
}
