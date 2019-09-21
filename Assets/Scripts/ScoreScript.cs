using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    static long score;
    public Text text;

    public void IncreaseScore(int pointValue)
    {
        score += pointValue;
        text.text = "" + score;
    }
}
