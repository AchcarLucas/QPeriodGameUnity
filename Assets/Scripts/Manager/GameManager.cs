using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public SaveManager _SaveManager;
    public EventScore _EventScore;

    public int GameScore = 0;

    private void Awake() 
    {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(this);
        Instance = this;

        _SaveManager = new SaveManager();
        _SaveManager.InitializeSaveManager();
        _SaveManager.LoadRanking();
    }

    public void TriggerScoreLogic(int gain)
    {
        GameScore += gain;
        
        _EventScore.ChangeGainScoreText(gain);
        _EventScore.ChangeGameScoreText(GameScore);
    }
}
