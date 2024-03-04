using UnityEngine;
using TMPro;

public class ScoreController2 : MonoBehaviour
{
    public TextMeshProUGUI score2Text;
    public int player2Score = 0;

    void Start()
    {
        UpdateScore2Text();
    }

    public void Player2Scored()
    {
        player2Score++;
        UpdateScore2Text();
    }

    void UpdateScore2Text()
    {
        score2Text.text = "Player 2 Score: " + player2Score;
    }
}
