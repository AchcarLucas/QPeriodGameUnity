using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class CardElement : CommonElement, ISelectHandler
{
    [SerializeField]

    public TMP_Text AttemptValueText;

    [Header("Status Element")]
    public Settings.Status CurrentStatus = Settings.Status.NONE;

    [Header("Front Background")]
    public Image Front;

    private int CurrentAttempt = 0;
    private Animator CardAnimator;

    void Start()
    {
        CurrentAttempt = ElementManager.Instance.MAX_ATTEMPT_TO_FAILED;
        CardAnimator = gameObject.GetComponent<Animator>();

        EditElementSymbolText();
        EditElementNameText();
        EditAttemptText();

        Front.color = Settings.GetMaterialColor(OwnStructChemicalElement.TMaterial);
    }

    public void EditAttemptText(string text = null)
    {
        if(text != null)
            ElementNameText.text = text;
        else
            AttemptValueText.text = this.CurrentAttempt + "/" + ElementManager.Instance.MAX_ATTEMPT_TO_FAILED;
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

    public bool HasFailed()
    {
        return this.CurrentAttempt <= 0;
    }

    public void VerifyFailure()
    {
        /*
            Se o número de tentativas for alcançado,
            a carta irá simplesmente informar que falhou
        */
        if(HasFailed()) {
            ActiveFailed();
            this.CurrentAttempt = 0;
        }
    }

    public void HitMiss()
    {
        if(CurrentStatus == Settings.Status.NONE) {
            this.CurrentAttempt--;
            TriggerMiss();
            VerifyFailure();
        }
        
        EditAttemptText();
    }

    public int CalculateScore()
    {
        // O score é calculado em potência de 2
        return (int)Mathf.Pow(2, CurrentAttempt);
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
