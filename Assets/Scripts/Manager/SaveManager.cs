using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

using UnityEngine;

public class SaveManager
{
    private const int MAX_RANKING = 100;
    private StructData[] RankingDataArray = new StructData[SaveManager.MAX_RANKING];

    public void InitializeSaveManager()
    {
        Debug.Log(Application.persistentDataPath);

        for(int index = 0; index < GetMaxRankingDataArray(); ++index)
        {
            StructData data = new StructData();
            data.name = null;
            data.game_score = data.game_time = 0;
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
                Debug.LogWarning(FilePath + " don't exist");
            }

            return true;
        }
        catch (Exception e) {
            throw e;
        }
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

    public bool CheckAreIntoRanking(uint score)
    {
        if(RankingDataArray[MAX_RANKING - 1].game_score < score)
            return true;

        return false;
    }

    public bool InsertIntoRankingData(StructData data)
    {
        // verifica se está no ranking, se estiver, salva no ranking e retorna true
        if(CheckAreIntoRanking(data.game_score)) {
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
                    return c2.game_time.CompareTo(c1.game_time);
                return c1.game_score.CompareTo(c2.game_score);
            });

        Array.Reverse(RankingDataArray);
    }
}
