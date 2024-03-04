using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOver;

    // Start is called before the first frame update
    void Start()
    {
        // Initially hide the Game Over text
        gameOver.gameObject.SetActive(false);
    }

    public void HideGameOver()
    {
        // Hide the game over text
        gameOver.gameObject.SetActive(false);
    }

    public void ShowGameOver()
    {
        // Show the Game Over text
        gameOver.gameObject.SetActive(true);
    }
}
