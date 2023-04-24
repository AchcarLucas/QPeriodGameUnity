using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public SaveManager _SaveManager;

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

    public int GetGameScore()
    {
        return GameScore;
    }

    public void SetGameScore(int score)
    {
        GameScore = score;
    }

    public int AddGameScore(int gain)
    {
        GameScore += gain;
        
        return GameScore;
    }
}
