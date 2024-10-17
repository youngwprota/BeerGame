using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int playerScore; 
    public static int botScore;

    void Start()
    {
        playerScore = 0;
        botScore = 0;
    }

    public void AddPlayerScore()
    {
        playerScore += 1;
    }

    public void AddbotScore()
    {
        botScore += 1 ;
    }
}
