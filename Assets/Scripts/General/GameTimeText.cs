using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using TMPro;

[RequireComponent(typeof(TMP_Text))]

public class GameTimeText : MonoBehaviour
{
    [HideInInspector]
    public static DateTime _StartTime = DateTime.Now;
    public static DateTime _CurrentTime = _StartTime;

    // quantos segundos já se passaram até o inicio do jogo
    public static uint Second = 0;
    public static uint LastSecond = 0;
    
    private TMP_Text _GameTimeText;

    public void Start()
    {
        _GameTimeText = this.GetComponent<TMP_Text>();
    }

    public void FixedUpdate()
    {
        _CurrentTime = DateTime.Now;
        TimeSpan TimePassed = _CurrentTime - _StartTime;

        Second = (uint)TimePassed.TotalSeconds;

        if(Second != LastSecond) {
            LastSecond = Second;
            GameManager.Instance.SetGameTime(Second);
            _GameTimeText.text = "Tempo: " + Second + " segundo(s)";
        }
    }
}
