using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip gameOverSound;
    void Start()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentLevelIndex == 4)
        {
            audioSource.clip = gameOverSound;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
