using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class TableOutlineElement : MonoBehaviour, IPointerClickHandler
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

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            OnVerifyElement();
    }

    public void OnVerifyElement()
    {
        ref GameObject SelectedElement = ref ElementManager.Instance.ObjectSelectedCardElement;

        if(SelectedElement == null)
            return;

        CardElement SelectedCardElement = SelectedElement.GetComponent<CardElement>();

        /*
            Verifica se o TableOutlineElement é o mesmo do CardElement,
            se for, chama a função para criar o elemento de tabela
        */
        if( SelectedCardElement.OwnStructChemicalElement.AtomicNumber ==
            this.OwnStructChemicalElement.AtomicNumber) {
                ElementManager.Instance.CreateTableElement(SelectedCardElement);
                SelectedCardElement.ActiveSuccess();
            }
    }

    void EditAtomicNumberText(string Text = null)
    {
        if(Text != null)
            AtomicNumberText.text = Text;
        else
            AtomicNumberText.text = OwnStructChemicalElement.AtomicNumber.ToString();
    }
}
