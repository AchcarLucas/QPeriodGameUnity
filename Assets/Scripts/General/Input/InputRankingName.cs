using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(TMP_InputField))]
public class InputRankingName : MonoBehaviour
{
    TMP_InputField Input;
    GameManager GameManager_Instance = null;

    const int MIN_LENGTH_TO_CONTINUE = 5;

    public Button ContinueButton;

    private void Awake()
    {
        GameManager_Instance = GameManager.Instance;

        Input = GetComponent<TMP_InputField>();
        Input.text = GameManager_Instance.GetRankingName();

        CheckTextToContinueButton();
    }

    private void CheckTextToContinueButton()
    {
        ContinueButton.interactable = Input.text.Length >= MIN_LENGTH_TO_CONTINUE;
    }

    public void OnRankingNameChanged(string name)
    {
        GameManager_Instance.SetRankingName(name);
        CheckTextToContinueButton();
    }
}
