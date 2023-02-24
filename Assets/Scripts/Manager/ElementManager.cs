using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ElementManager : MonoBehaviour
{
    public static ElementManager Instance;

    public List<Element> ChemicalElements;

    private void Awake() {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;

        ChemicalElements = Creator.CreateChemicalElements();
    }
}
