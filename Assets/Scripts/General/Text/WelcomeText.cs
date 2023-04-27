using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class WelcomeText : MonoBehaviour
{
    TMP_Text _WelcomeText = null;
    GameManager GameManager_Instance = null;

    private void Awake()
    {
        GameManager_Instance = GameManager.Instance;
        
        _WelcomeText = GetComponent<TMP_Text>();
        string text = _WelcomeText.text;
         _WelcomeText.text = text.Replace("{name}", GameManager_Instance.GetRankingName());;
    }
}
