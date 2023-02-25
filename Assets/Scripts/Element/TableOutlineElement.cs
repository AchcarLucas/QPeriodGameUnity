using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    /*
        Mouse Event Hover
    */
    
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }

    void EditAtomicNumberText(string Text = null)
    {
        if(Text != null)
            AtomicNumberText.text = Text;
        else
            AtomicNumberText.text = OwnStructChemicalElement.AtomicNumber.ToString();
    }
}
