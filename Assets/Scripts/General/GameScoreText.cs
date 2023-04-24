using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

[RequireComponent(typeof(TMP_Text))]
[RequireComponent(typeof(Animator))]
public class GameScoreText : MonoBehaviour
{
    [HideInInspector]
    public static uint _CurrentGameScore = 0;
    public static uint _TransitoryGameScore = 0;

    private Animator _GameScoreAnimator;

    private TMP_Text _GameScoreText;

    public void Start()
    {
        _GameScoreAnimator = this.GetComponent<Animator>();
        _GameScoreText = this.GetComponent<TMP_Text>();
    }

    public void EventTransitoryGameScore()
    {
        _CurrentGameScore = _TransitoryGameScore;
        _GameScoreText.text = "Score: " + _CurrentGameScore.ToString();
    }

    public void ChangeGameScoreText(uint score)
    {
       _TransitoryGameScore = score;
       _GameScoreAnimator.SetTrigger("AddOne");
    }
}
