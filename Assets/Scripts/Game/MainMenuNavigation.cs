using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuNavigation : MonoBehaviour
{
    [SerializeField] GameObject mainMenuPrefab;
    [SerializeField] GameObject inGamePrefab;

    public void PlayGame()
    {
        mainMenuPrefab.SetActive(false);
        inGamePrefab.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
