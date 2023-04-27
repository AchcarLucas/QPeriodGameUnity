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

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Scene " + scene.name + " has Loaded");
        
        /*
         Caso seja um Loaded de Scene e estiver indo para o Game ou para o Menu,
         simplesmente damos um reset no jogo
        */
        if ((scene.name == "Game" || scene.name == "Menu") && Instance != null)
            Instance.ResetGame();
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
}
