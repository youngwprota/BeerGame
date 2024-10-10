using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        botScore +=1 ;
    }
}
