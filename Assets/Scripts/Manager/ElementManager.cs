using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour
{
    public static ElementManager Instance;
    public static List<Element> StructChemicalElements;

    private void Awake() {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;

        StructChemicalElements = Helper.Shuffle(Creator.CreateChemicalElements());
    }
}
