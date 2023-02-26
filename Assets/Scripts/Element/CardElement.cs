using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class CardElement : MonoBehaviour, ISelectHandler
{
    const int MAX_ATTEMPT = 5;

    [SerializeField]
    [Header("Struct Chemical Element")]
    public Element OwnStructChemicalElement;
    
    [Header("Status Element")]
    public Settings.Status CurrentStatus = Settings.Status.NONE;

    [Header("Front Background")]
    public Image Front;

    [Header("TMP_Texts Element")]
    public TMP_Text AttemptValueText;
    public TMP_Text ElementSymbolText;
    public TMP_Text ElementNameText;

    private int CurrentAttempt = MAX_ATTEMPT;
    private Animator CardAnimator;

    /*
        Internal Events
    */

    void Start()
    {
        CardAnimator = gameObject.GetComponent<Animator>();

        EditAttemptText();
        EditElementSymbolText();
        EditElementNameText();

        Front.color = Settings.GetMaterialColor(OwnStructChemicalElement.TMaterial);
    }

    public void OnSelect(BaseEventData eventData)
    {
        ref GameObject PreviousSelected = ref ElementManager.Instance.ObjectSelectedCardElement;

        /*
            Unselected a carta anterior para ativar a atual
        */
        if(PreviousSelected != null) {
            CardElement PreviousCardElement = PreviousSelected.GetComponent<CardElement>();
            PreviousCardElement.TriggerUnselected();
        }

        /*
            Ativa a carta que foi selecionada e mantém salvo o elemento selecionado
        */
        this.TriggerSelected();
        PreviousSelected = gameObject;
    }

    /*
       Generic Functions
    */

    public int CalculateScore()
    {
        // O score é calculado em potência de 2
        return (int)Mathf.Pow(2, CurrentAttempt);
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

    public void EditAttemptText(string text = null)
    {
        if(text != null)
            ElementNameText.text = text;
        else
            AttemptValueText.text = this.CurrentAttempt + "/" + MAX_ATTEMPT;
    }

    public string GetElementSymbolText()
    {
        return ElementSymbolText.text;
    }

    public void HasFailed()
    {
        if(Settings.Status.FAILED)
            return true;
            
        return false;
    }

    public void HitMiss()
    {
        if(CurrentStatus == Settings.Status.NONE) {
            this.CurrentAttempt--;
            TriggerMiss();
            
            /*
                Se o número de tentativas for alcançado,
                a carta irá simplesmente informar que falhou
            */
            if(this.CurrentAttempt <= 0) {
                ActiveFailed();
                this.CurrentAttempt = 0;
            }
        }
        
        EditAttemptText();
    }

    public void TriggerSelected()
    {
        this.CardAnimator.SetTrigger("Selected");
    }

    public void TriggerUnselected()
    {
        this.CardAnimator.SetTrigger("Unselected");
    }

    public void TriggerMiss()
    {
        this.CardAnimator.SetTrigger("Miss");
    }

    public void ActiveFailed()
    {
        this.CardAnimator.SetBool("Failed", true);
        CurrentStatus = Settings.Status.FAILED;
    }

    public void ActiveSuccess()
    {
        this.CardAnimator.SetBool("Success", true);
        CurrentStatus = Settings.Status.SUCCESS;
    }
}
