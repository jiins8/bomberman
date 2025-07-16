using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] players;
    public AudioSource audioSource;
    public AudioClip level1, level2, level3;


    private void Start()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentLevelIndex == 1)
        {
            audioSource.clip = level1;
        }
        if (currentLevelIndex == 2)
        {
            audioSource.clip = level2;
        }
        if (currentLevelIndex == 3)
        {
            audioSource.clip = level3;
        }
    }
    public void CheckWinState()
    {
        int aliveCount = 0;

        foreach (GameObject player in players)
        {
            if (player.activeSelf)
            {
                aliveCount++;
            }
            if (aliveCount <= 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            }
        }

    }
}
