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
        List<Element> struct_elements = ElementManager.ChemicalElements;

        Debug.Log("Instantiate " + struct_elements.Count + " element(s) card");

        foreach(Element struct_element in struct_elements) {
            // Cria a instancia do objeto da carta no SlideView
            GameObject card = GameObject.Instantiate(ElementCardTemplate, this.transform);
            // Adiciona a estrutura elemento dentro da carta
            card.GetComponent<CardElement>().OwnStructElement = struct_element;
        }
    }
}
