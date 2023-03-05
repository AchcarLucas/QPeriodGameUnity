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
                Debug.Log("[" + index + "] - Name: " + RankingDataArray[index].name + " GameScore: " + RankingDataArray[index].game_score + " Minutes: " + RankingDataArray[index].minutes);
            }
        }
    }

    public void PopulateRankingTest()
    {
        Debug.Log("Populate Ranking Function");

        for(int index = 0; index < _SaveManager.GetMaxRankingDataArray(); ++index)
        {
            StructData data = new StructData();

            data.name = GenerateRandomName();
            data.game_score = GenerateGameScore();
            data.minutes = GenerateMinutesTime();

            _SaveManager.InsertIntoRankingData(data);
        }

        Debug.Log("Already Populated");
    }

    public void InsertRankingTest()
    {
        StructData data = new StructData();

        data.name = GenerateRandomName();
        data.game_score = GenerateGameScore();
        data.minutes = GenerateMinutesTime();

        _SaveManager.InsertIntoRankingData(data);

        Debug.Log("[Insert] - Name: " + data.name + " GameScore: " + data.game_score + " Minutes: " + data.minutes);
    }

    private int GenerateMinutesTime()
    {
        System.Random r = new System.Random();
        TimeSpan Diff = DateTime.Now.AddMinutes(r.Next(100, 10000)) - DateTime.Now;
        return (int)(Diff.TotalSeconds / 60);
    }

    private int GenerateGameScore()
    {
        System.Random r = new System.Random();
        return r.Next(0, 3776);
    }

    // https://stackoverflow.com/questions/42468014/creating-a-name-generator-for-unity-project-c-sharp
    private string GenerateRandomName()
    {
        System.Random r = new System.Random();

        string[] NameComponentFirst = new string[] {"Ge","Me","Ta","Bo","Ke","Ra","Ne","Mi" };
        string[] NameComponentSecond = new string[] {"oo","ue","as","to","ra","me","io","so" };
        string[] NameComponentThird = new string[] {"se.","matt.","lace.","fo.","cake.","end." };

        string Name = NameComponentFirst[r.Next(0, NameComponentFirst.Length - 1)];
        Name += NameComponentSecond[r.Next(0, NameComponentSecond.Length - 1)];
        Name += NameComponentThird[r.Next(0, NameComponentThird.Length - 1)];

        return Name;
    }
}
