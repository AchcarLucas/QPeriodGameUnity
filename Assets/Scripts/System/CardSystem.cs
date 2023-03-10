using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSystem : MonoBehaviour
{
    [Header("Prefab Elements Card")]
    public GameObject ElementCardTemplate;

    private ElementManager _EManager = ElementManager.Instance;

    public void Awake()
    {
        CreateCardElements();
    }

    public void CreateCardElements()
    {
        List<Element> StructChemicalElements = ElementManager.StructChemicalElements;

        Debug.Log("Instantiate " + StructChemicalElements.Count + " element(s) card");

        foreach(Element StructChemicalElement in StructChemicalElements) {
            // Cria a instancia do objeto da carta no SlideView
            GameObject CardObject = GameObject.Instantiate(ElementCardTemplate, this.transform);

            // Adiciona a estrutura elemento dentro da carta
            CardObject.GetComponent<CardElement>().OwnStructChemicalElement = StructChemicalElement;

            CardObject.name = Settings.BaseNameCardElement + StructChemicalElement.Column + StructChemicalElement.Line;
        }
    }
}