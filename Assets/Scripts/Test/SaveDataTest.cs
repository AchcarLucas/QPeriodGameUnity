using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class SaveDataTest : MonoBehaviour
{
    public SaveManager _SaveManager = new SaveManager();

    public void Awake()
    {
        _SaveManager.InitializeSaveManager();
    }

    public void SaveRankingTest()
    {
        Debug.Log("Save Ranking Function");

        try {
            _SaveManager.SaveRanking();
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }

    public void LoadRankingTest()
    {
        Debug.Log("Load Ranking Function");

        try {
            _SaveManager.LoadRanking();
        } catch (Exception e) {
            Debug.LogException(e, this);
        }
    }

    public void ShowRankingSortedTest()
    {
        Debug.Log("Show Ranking Function");

        StructData[] RankingDataArray = _SaveManager.GetRankingDataArray();
        
        for(int index = 0; index < _SaveManager.GetMaxRankingDataArray(); ++index) {
            if(RankingDataArray[index].name != null) {
                Debug.Log("[" + index + "] - Name: " + RankingDataArray[index].name + " GameScore: " + RankingDataArray[index].game_score + " Secunds: " + RankingDataArray[index].game_time);
            }
        }
    }

    public void PopulateRankingTest()
    {
        Debug.Log("Populate Ranking Function");

        for(int index = 0; index < _SaveManager.GetMaxRankingDataArray(); ++index)
        {
            StructData data = new StructData();

            data.name = Helper.GenerateRandomName();
            data.game_score = GenerateGameScore();
            data.game_time = GenerateGameSecundTime();

            _SaveManager.InsertIntoRankingData(data);
        }

        Debug.Log("Already Populated");
    }

    public void InsertRankingTest()
    {
        StructData data = new StructData();

        data.name = Helper.GenerateRandomName();
        data.game_score = GenerateGameScore();
        data.game_time = GenerateGameSecundTime();

        _SaveManager.InsertIntoRankingData(data);

        Debug.Log("[Insert] - Name: " + data.name + " GameScore: " + data.game_score + " Secunds: " + data.game_time);
    }

    private uint GenerateGameSecundTime()
    {
        System.Random r = new System.Random();
        TimeSpan Diff = DateTime.Now.AddMinutes(r.Next(100, 10000)) - DateTime.Now;
        return (uint)Diff.TotalSeconds;
    }

    private uint GenerateGameMinuteTime()
    {
        return (uint)(GenerateGameSecundTime() / 60);
    }

    private uint GenerateGameScore()
    {
        System.Random r = new System.Random();
        return (uint)r.Next(0, 3776);
    }
}
