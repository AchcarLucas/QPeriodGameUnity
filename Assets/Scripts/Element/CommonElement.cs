using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class CommonElement : MonoBehaviour
{
    [SerializeField]
    [Header("Struct Chemical Element")]
    public Element OwnStructChemicalElement;

    [Header("TMP_Texts Element")]
    public TMP_Text ElementSymbolText;
    public TMP_Text ElementNameText;

    public void EditElementSymbolText(string text = null)
    {
        if(text != null)
            ElementNameText.text = text;
        else
            ElementSymbolText.text = OwnStructChemicalElement.ElementSymbol;
    }

    public void EditElementNameText(string text = null)
    {
        if(text != null)
            ElementNameText.text = text;
        else
            ElementNameText.text = OwnStructChemicalElement.ElementName;
    }

    public string GetElementSymbolText()
    {
        return ElementSymbolText.text;
    }

    public string GetElementNameText()
    {
        return ElementNameText.text;
    }
}