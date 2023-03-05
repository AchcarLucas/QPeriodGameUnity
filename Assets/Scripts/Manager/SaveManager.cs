using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

using UnityEngine;

public class SaveManager
{
    private const int MAX_RANKING = 10;
    private StructData[] RankingDataArray = new StructData[SaveManager.MAX_RANKING];

    public void InitializeSaveManager()
    {
        for(int index = 0; index < GetMaxRankingDataArray(); ++index)
        {
            StructData data = new StructData();
            data.name = null;
            data.game_score = data.minutes = 0;
            RankingDataArray[index] = data;
        }
    }

    public bool SaveRanking(string FileData = "RankingData.dat")
    {
        try {
            string FilePath = Application.persistentDataPath + '/' + FileData;
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(FilePath);
            bf.Serialize(file, RankingDataArray);
            file.Close();
            Debug.Log("RankingDataArray saved");
            return true;
        }
        catch (Exception e) {
            throw e;
        }

        return false;
    }

    public bool LoadRanking(string FileData = "RankingData.dat")
    {
        try {
            string FilePath = Application.persistentDataPath + '/' + FileData;

            if (File.Exists(FilePath)) {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(FilePath, FileMode.Open);
                RankingDataArray = (StructData[])bf.Deserialize(file);
                file.Close();

                Debug.Log("RankingDataArray loaded");
            } else {
                Debug.LogError(FilePath + " don't exist");
            }

            return true;
        }
        catch (Exception e) {
            throw e;
        }
        
        return false;
    }

    public int GetMaxRankingDataArray()
    {
        return MAX_RANKING;
    }

    public StructData[] GetRankingDataArray()
    {
        return RankingDataArray;
    }

    public StructData GetRankingDataIndex(int index)
    {
        if(index >= 0 && index < MAX_RANKING) {
            return RankingDataArray[index];
        }

        return null;
    }

    public bool InsertIntoRankingData(StructData data)
    {
        // verifica se o GameScore atual é menor que o game_score posterior
        // se for, coloca na última e faz o sorted

        if(RankingDataArray[MAX_RANKING - 1].game_score < data.game_score) {
            RankingDataArray[MAX_RANKING - 1] = data;
            // Refaz a ordenação
            SortedRankingDataArray();
            return true;
        }
        
        return false;
    }

    private bool SetRankingDataIndex(int index, StructData data)
    {
        if(index >= 0 && index < MAX_RANKING) {
            RankingDataArray[index] = data;
            return true;
        }

        return false;
    }

    private void SortedRankingDataArray()
    {
        // Sort usando GameScore 
        Array.Sort<StructData>(RankingDataArray, delegate(StructData c1, StructData c2) {
                if(c1.game_score.Equals(c2.game_score))
                    return c1.minutes.CompareTo(c2.minutes);
                return c1.game_score.CompareTo(c2.game_score);
            });

        Array.Reverse(RankingDataArray);
    }
}
