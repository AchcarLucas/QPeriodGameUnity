using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScore : MonoBehaviour
{
    public static EventScore Instance;

    public GainScoreText GainScoreObject;
    public GameScoreText GameScoreObject;

    private void Awake()
    {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
    }

    protected void ChangeGainScoreText(uint gain)
    {
        GainScoreObject.ChangeGainScoreText(gain);
    }

    protected void ChangeGameScoreText(uint score)
    {
        GameScoreObject.ChangeGameScoreText(score);
    }

    public void TriggerScoreLogic(uint gain)
    {
        uint GameScore = GameManager.Instance.AddGameScore(gain);

        ChangeGainScoreText(gain);
        ChangeGameScoreText(GameScore);
    }
}
