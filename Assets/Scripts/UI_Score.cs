using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Score : MonoBehaviour
{
    public Text collectedText;

    public static bool GameEnded = false;

    public GameObject gameEndMenu;

    public int collected = 0;
    public int total = 7;

    void Start()
    {
        if (collectedText == null)
        {
            collected = 0;
            collectedText = GetComponent<Text>();
        }
    }

    void Update()
    {
        collectedText.text = collected + "/ 10";
        if (collected == total)
        {
            GameEnd();
        }
    }

    void GameEnd()
    {
        gameEndMenu.SetActive(true);
        Time.timeScale = 0f;
        GameEnded = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
}
