using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

[RequireComponent(typeof(TMP_Text))]
[RequireComponent(typeof(Animator))]
public class GainScoreText : MonoBehaviour
{
    [HideInInspector]
    private Animator _GainScoreAnimator;

    private TMP_Text _GainScoreText;

    public void Start()
    {
        _GainScoreAnimator = this.GetComponent<Animator>();
        _GainScoreText = this.GetComponent<TMP_Text>();
    }

    public void ChangeGainScoreText(uint gain)
    {
        _GainScoreText.text = '+' + gain.ToString();
        _GainScoreAnimator.SetTrigger("JumpGainScore");
    }
}
