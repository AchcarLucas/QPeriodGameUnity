using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class RankingTemplateInfo : MonoBehaviour
{
    public TMP_Text _Name;
    public TMP_Text _Score;
    public TMP_Text _Time;
    public TMP_Text _Index;

    public void SetName(string name)
    {
        _Name.text = name;
    }

    public void SetScore(int score)
    {
        _Score.text = score.ToString();
    }

    public void SetTime(int time)
    {
        _Time.text = time.ToString();
    }

    public void SetIndex(int index)
    {
        _Index.text = index.ToString();
    }
}
