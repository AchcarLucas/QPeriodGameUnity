using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSystem : MonoBehaviour
{
    [Header("Prefab Element Card")]
    public GameObject ElementCardTemplate;

    private ElementManager EManager = ElementManager.Instance;

    public void Awake()
    {
        CreateCardElement();
    }

    public void CreateCardElement()
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