using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventWon : MonoBehaviour
{
    public static EventWon Instance;

    public GameObject[] ObjectListToEnableWhenWon;
    public GameObject[] ObjectListToDisableWhenWon;

    private void Awake()
    {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
    }

    public void FixedUpdate()
    {
        if(ElementManager.Instance.IsEndGame())
        {
            foreach(GameObject _object in ObjectListToEnableWhenWon)
                _object.SetActive(true);

            foreach(GameObject _object in ObjectListToDisableWhenWon)
                _object.SetActive(false);
        }
    }
}
