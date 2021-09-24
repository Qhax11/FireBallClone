using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance; 
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public GameObject againButton;

    private void Awake()
    {
        Instance = this;
    }

    public void GameLose()
    {
        gameOverUI.SetActive(true);
        againButton.SetActive(true);

    }

    public void GameWin()
    {
        gameWinUI.SetActive(true);
        againButton.SetActive(true);
    }
}
