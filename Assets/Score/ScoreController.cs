using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI score1Text;
    private int player1Score = 0;

    void Start()
    {
        UpdateScore1Text();
    }

    public void Player1Scored()
    {
        player1Score++;
        UpdateScore1Text();
    }

    void UpdateScore1Text()
    {
        score1Text.text = "Player 1 Score: " + player1Score;
    }
}
