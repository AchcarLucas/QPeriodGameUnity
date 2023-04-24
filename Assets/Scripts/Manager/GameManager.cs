using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public SaveManager _SaveManager;

    public String RankingName = Helper.GenerateRandomName();

    private uint GameScore = 0;
    private uint GameTime = 0;

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

    public uint GetGameScore()
    {
        return GameScore;
    }

    public void SetGameScore(uint score)
    {
        GameScore = score;
    }

    public uint AddGameScore(uint gain)
    {
        GameScore += gain;
        
        return GameScore;
    }

    public uint GetGameTime()
    {
        return GameTime;
    }

    public void SetGameTime(uint time)
    {
        GameTime = time;
    }

    public uint AddGameTime(uint inc)
    {
        GameTime += inc;
        
        return GameTime;
    }
}
