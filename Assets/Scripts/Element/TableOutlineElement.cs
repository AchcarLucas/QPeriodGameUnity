using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class TableOutlineElement : MonoBehaviour
{
    [SerializeField]
    [Header("Struct Chemical Element")]
    public Element OwnStructChemicalElement;

    [Header("TMP_Texts Element")]
    public TMP_Text AtomicNumberText;

    void Start()
    {
        EditAtomicNumberText();
    }

    void EditAtomicNumberText(string Text = null)
    {
        if(Text != null)
            AtomicNumberText.text = Text;
        else
            AtomicNumberText.text = OwnStructChemicalElement.AtomicNumber.ToString();
    }
}
