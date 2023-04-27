using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using TMPro;

[RequireComponent(typeof(TMP_Text))]

public class GameTimeText : MonoBehaviour
{
    [HideInInspector]
    public DateTime _StartTime;
    public DateTime _CurrentTime;

    // quantos segundos já se passaram até o inicio do jogo
    public uint Second = 0;
    public uint LastSecond = 0;
    
    private TMP_Text _GameTimeText;

    public void Start()
    {
        _GameTimeText = this.GetComponent<TMP_Text>();
        _StartTime = _CurrentTime = DateTime.Now;
    }

    public void FixedUpdate()
    {
        _CurrentTime = DateTime.Now;
        TimeSpan TimePassed = _CurrentTime - _StartTime;

        Second = (uint)TimePassed.TotalSeconds;

        if(Second != LastSecond) {
            LastSecond = Second;
            GameManager.Instance.SetGameTime(Second);
            _GameTimeText.text = "Tempo: " + String.Format("{0:D2}", Second) + " segundo(s)";
        }
    }
}
