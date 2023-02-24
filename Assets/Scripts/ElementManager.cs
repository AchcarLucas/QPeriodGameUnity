using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour
{
    public static ElementManager Instance;

    public List<Element> ChemicalElements = new List<Element>();

    private void Awake() {
        Instance = this;
    }
}
