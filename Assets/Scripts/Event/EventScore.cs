using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScore : MonoBehaviour
{
    public GainScoreText GainScoreObject;
    public GameScoreText GameScoreObject;

    public void ChangeGainScoreText(int gain)
    {
        GainScoreObject.ChangeGainScoreText(gain);
    }

    public void ChangeGameScoreText(int score)
    {
        GameScoreObject.ChangeGameScoreText(score);
    }
}
