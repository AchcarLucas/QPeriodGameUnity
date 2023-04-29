using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class CompletedGameText : MonoBehaviour
{
    TMP_Text _CompletedText = null;
    GameManager GameManager_Instance = null;

    private string text = null;

    private void Awake()
    {
        GameManager_Instance = GameManager.Instance;

        _CompletedText = GetComponent<TMP_Text>();

        text = _CompletedText.text;
    }

    public void OnEnable()
    {
        string _text = text.Replace("{time}", GameManager_Instance.GetGameTime().ToString());
        _text = _text.Replace("{score}", GameManager_Instance.GetGameScore().ToString());
        _CompletedText.text = _text;
    }
}
