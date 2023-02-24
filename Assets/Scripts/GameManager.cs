using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject ObjectSelectedElementTable;

    private void Awake() {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
    }
}