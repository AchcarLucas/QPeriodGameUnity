using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class TableOutlineElement : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    [Header("Prefab Elements Table")]
    public GameObject ElementTableTemplate;

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
        {
            ref GameObject SelectedElement = ref GameManager.Instance.ObjectSelectedCardElement;

            if(SelectedElement == null)
                return;

            CardElement SelectedCardElement = SelectedElement.GetComponent<CardElement>();

            /*
                Verifica se o TableOutlineElement é o mesmo do CardElement
                se for, cria o TableElement e destroi esse objeto
            */
            if( SelectedCardElement.OwnStructChemicalElement.AtomicNumber ==
                this.OwnStructChemicalElement.AtomicNumber) {
                    GameObject TableObject = GameObject.Instantiate(
                    ElementTableTemplate,
                    gameObject.transform.parent);

                    TableObject.GetComponent<TableElement>().OwnStructChemicalElement = OwnStructChemicalElement;

                    RectTransform RectTableObject = TableObject.GetComponent<RectTransform>();
                    RectTableObject.anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;

                    Destroy(this.gameObject);
                }
            
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
