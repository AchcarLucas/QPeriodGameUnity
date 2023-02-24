using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSystem : MonoBehaviour
{
    public GameObject ElementCardTemplate;
    private ElementManager EManager = ElementManager.Instance;

    public void Awake()
    {
        List<Element> elements = EManager.ChemicalElements;
        foreach(Element element in elements) {
            // cria a instancia da carta
            GameObject card = GameObject.Instantiate(ElementCardTemplate, this.transform);
            // adiciona o elemento dentro da carta
            card.GetComponent<CardElement>().OwnElement = element;
        }
    }
}
