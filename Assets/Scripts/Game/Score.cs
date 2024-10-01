using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score 
{
    private int playerScore; 

    private int botScore;

    public Score() 
    {
        this.playerScore = 0;
        this.botScore = 0;
    }

    public void IncreasePlayerScore()
    {
        playerScore++;
    }
    
    public void IncreaseBotScore()
    {
        botScore++;
    }

    public int getPlayerScore()
    {
        return playerScore;
    }

    public int getBotScore()
    {
        return botScore;
    }
}
