using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScrpit : MonoBehaviour
{

    public int playerScore;
    public Text score;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        score.text = playerScore.ToString();
    }
    public void setScoreToZero()
    {
        playerScore = 0;
        score.text = playerScore.ToString();
    }
}
