using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Sprite botImage;  
    public AudioClip botAudio;
    public float botWidth;
    public float ballSpeed;
    public void Quit()
    {
        Application.Quit();
    }

    public void ChooseLevel()
    {

        SceneManager.LoadScene("ChooseLevels");
    }

    public void Play()
    {
        GameData.botImage = botImage;
        GameData.botAudio = botAudio;
        GameData.botWidth = botWidth;
        GameData.ballSpeed = ballSpeed;
        SceneManager.LoadScene("SampleScene");
    }

    public void PlayerWin()
    {
        SceneManager.LoadScene("PlayerWin");
    }

    public void BotWin()
    {
        SceneManager.LoadScene("BotWin");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
