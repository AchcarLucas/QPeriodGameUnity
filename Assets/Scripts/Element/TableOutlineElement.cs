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
            OnVerifyAttemptElement();
    }

    public void OnVerifyAttemptElement()
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
                
                // Incrementa o GameScore
                EventScore.Instance.TriggerScoreLogic(SelectedCardElement.CalculateScore());

                return;
            }

        // Caso não seja do elemento, chama a função HitMiss e retira uma chance
        SelectedCardElement.HitMiss();

        /*
            Caso já tenha ocorrido um failed, tiramos ele de objeto selecionado
            e criamos o elemento de tabela do elemento selecionado
        */
        if(SelectedCardElement.HasFailed()) {
            ElementManager.Instance.CreateTableElement(SelectedCardElement);
            SelectedElement = null;
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
