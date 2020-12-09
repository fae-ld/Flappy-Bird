using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variable Declare
    public GameObject gameOverCanvas;

    public void Start()
    {
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
