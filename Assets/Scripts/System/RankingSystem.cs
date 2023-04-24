using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingSystem : MonoBehaviour
{
    public GameObject RankingTemplate;
    
    public void Start()
    {
        ref SaveManager _SaveManager = ref GameManager.Instance._SaveManager;

        StructData[] RankingDataArray = _SaveManager.GetRankingDataArray();
        
        for(int index = 0; index < _SaveManager.GetMaxRankingDataArray(); ++index) {    
            RectTransform Rect = this.GetComponent<RectTransform>();
            
            GameObject RankingColumn = GameObject.Instantiate(
                RankingTemplate,
                gameObject.transform
            );

            RectTransform RectRanking = RankingColumn.GetComponent<RectTransform>();
            
            Vector2 position = new Vector2(
                Rect.anchoredPosition.x, 
                (-1)*(index * RectRanking.rect.height) + RectRanking.rect.yMax
            );

            RectRanking.anchoredPosition = position;

            RankingTemplateInfo Info = RankingColumn.GetComponent<RankingTemplateInfo>();
            Info.SetIndex(index + 1);
            
            if(RankingDataArray[index].name != null) {
                Debug.Log("[" + index + "] - Name: " + RankingDataArray[index].name + " GameScore: " + RankingDataArray[index].game_score + " Minutes: " + RankingDataArray[index].minutes);

                Info.SetName(RankingDataArray[index].name);
                Info.SetScore(RankingDataArray[index].game_score);
                Info.SetTime(RankingDataArray[index].minutes);
            }
        }
    }
}
