using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class TableElement : CommonElement
{
    [SerializeField]
    
    public TMP_Text AtomicNumberText;

    [Header("Shaders Element")]
    public Image ShaderEffect;

    public void Start() 
    {
        EditElementSymbolText();
        EditElementNameText();
        EditAtomicNumberText();

        ShaderEffect.color = Settings.GetMaterialColor(OwnStructChemicalElement.TMaterial);
    }

    public void EditAtomicNumberText(string text = null)
    {
        if(text != null)
            AtomicNumberText.text = text;
        else
            AtomicNumberText.text = OwnStructChemicalElement.AtomicNumber.ToString();
    }
}