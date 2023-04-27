using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public SaveManager _SaveManager;

    public string RankingName = Helper.GenerateRandomName();

    public uint GameScore = 0;
    public uint GameTime = 0;

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

    public void ResetGame()
    {
        Debug.Log("Reset Game");

        GameScore = GameTime = 0;
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
        
        return Instance.GameScore;
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

    public void SetRankingName(string name)
    {
        RankingName = name;
    }

    public string GetRankingName()
    {
        return RankingName;
    }

    /*
     Quando o jogo terminar ou o usuário finalizar a partida,
     essa função irá ser chamada para salvar o resultado no ranking
     e mostrar o ranking para o usuário
    */
    public void FinishedMatch()
    {
        Debug.Log("FinishedMatch");

        StructData data = new StructData();

        data.name = RankingName;
        data.game_score = GameScore;
        data.game_time = GameTime;

        try {
            _SaveManager.InsertIntoRankingData(data);
            _SaveManager.SaveRanking();
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }
}
