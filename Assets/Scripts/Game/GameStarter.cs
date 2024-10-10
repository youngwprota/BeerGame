using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] GameObject mainMenuPrefab;
    [SerializeField] GameObject inGamePrefab;

    void Start()
    {
        mainMenuPrefab.SetActive(true);
        inGamePrefab.SetActive(false);
    }

    void Update()
    {
        
    }
}
