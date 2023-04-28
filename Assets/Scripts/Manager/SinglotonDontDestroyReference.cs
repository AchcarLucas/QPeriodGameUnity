using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglotonDontDestroyReference : MonoBehaviour
{
    /*
        Classe responsável por manter referência de
        algumas funções do GameManager
    */
    public static GameManager GameManager_Instance = null;

    public void Awake()
    {
        GameManager_Instance = GameManager.Instance;
    }

    public void ResetGame()
    {
        GameManager_Instance.ResetGame();
    }

    public void FinishedMatch()
    {
        GameManager_Instance.FinishedMatch();
    }
}
