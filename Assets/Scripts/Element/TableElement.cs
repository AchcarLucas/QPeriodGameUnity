using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class TableElement : MonoBehaviour
{
    [SerializeField]
    [Header("Struct Chemical Element")]
    public Element OwnStructChemicalElement;

    [Header("TMP_Texts Element")]
    public TMP_Text AtomicNumberText;
    public TMP_Text ElementSymbolText;
    public TMP_Text ElementNameText;

    private Image ShaderEffect;

    public void Start() 
    {
        ShaderEffect = this.GetComponent<Image>();

        EditElementSymbolText();
        EditElementNameText();
        EditAtomicNumberText();

        ShaderEffect.color = Settings.GetMaterialColor(OwnStructChemicalElement.TMaterial);
    }

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

    public void EditAtomicNumberText(string text = null)
    {
        if(text != null)
            AtomicNumberText.text = text;
        else
            AtomicNumberText.text = OwnStructChemicalElement.AtomicNumber.ToString();
    }
}