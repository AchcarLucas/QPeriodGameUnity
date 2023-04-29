using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using TMPro;

[RequireComponent(typeof(TMP_Text))]

public class GameTimeText : MonoBehaviour
{
    private TMP_Text _GameTimeText;

    public uint _Second = 0;
    public uint _LastSecond = 0;
    
    public void Start()
    {
        _GameTimeText = this.GetComponent<TMP_Text>();
    }

    public void FixedUpdate()
    {
        _Second = GameManager.Instance.GetGameTime();

        if(_Second != _LastSecond) {
            _LastSecond = _Second;
            _GameTimeText.text = "Tempo: " + String.Format("{0:D2}", _Second) + " segundo(s)";
        }
    }
}
