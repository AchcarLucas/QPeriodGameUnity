using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class TableOutlineElement : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    [Header("Struct Chemical Element")]
    public Element OwnStructChemicalElement;

    [Header("TMP_Texts Element")]
    public TMP_Text AtomicNumberText;

    private Animator TableAnimation;

    void Start()
    {
        TableAnimation = gameObject.GetComponent<Animator>();

        EditAtomicNumberText();
    }

    /*
        Mouse Event Hover
    */

    public void OnPointerEnter(PointerEventData eventData)
    {
        Hover(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
         Hover(false);
    }

    void EditAtomicNumberText(string Text = null)
    {
        if(Text != null)
            AtomicNumberText.text = Text;
        else
            AtomicNumberText.text = OwnStructChemicalElement.AtomicNumber.ToString();
    }

    void Hover(bool status) 
    {
        TableAnimation.SetBool("Hover", status);
    }
}
