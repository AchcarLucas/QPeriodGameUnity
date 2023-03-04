using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class CardElement : CommonElement, ISelectHandler
{
    public TMP_Text AttemptValueText;

    [Header("Status Element")]
    public Settings.Status CurrentStatus = Settings.Status.NONE;

    [Header("Front Background")]
    public Image Front;

    private int _CurrentAttempt = 0;
    private Animator _CardAnimator;

    void Start()
    {
        _CurrentAttempt = ElementManager.Instance.MAX_ATTEMPT_TO_FAILED;
        _CardAnimator = gameObject.GetComponent<Animator>();

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
            AttemptValueText.text = _CurrentAttempt + "/" + ElementManager.Instance.MAX_ATTEMPT_TO_FAILED;
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
        TriggerSelected();
        PreviousSelected = gameObject;
    }

    public bool HasFailed()
    {
        return _CurrentAttempt <= 0;
    }

    public void VerifyFailure()
    {
        /*
            Se o número de tentativas for alcançado,
            a carta irá simplesmente informar que falhou
        */
        if(HasFailed()) {
            ActiveFailed();
            _CurrentAttempt = 0;
        }
    }

    public void HitMiss()
    {
        if(CurrentStatus == Settings.Status.NONE) {
            _CurrentAttempt--;
            TriggerMiss();
            VerifyFailure();
        }
        
        EditAttemptText();
    }

    public int CalculateScore()
    {
        // O score é calculado em potência de 2
        return (int)Mathf.Pow(2, _CurrentAttempt);
    }

    public void TriggerSelected()
    {
        _CardAnimator.SetTrigger("Selected");

        SoundManager.PlaySound(SoundManager.Sound.Selected);
    }

    public void TriggerUnselected()
    {
        _CardAnimator.SetTrigger("Unselected");
    }

    public void TriggerMiss()
    {
        _CardAnimator.SetTrigger("Miss");

        SoundManager.PlaySound(SoundManager.Sound.Miss);
    }

    public void ActiveFailed()
    {
        _CardAnimator.SetBool("Failed", true);

        SoundManager.PlaySound(SoundManager.Sound.Failed);

        CurrentStatus = Settings.Status.FAILED;
    }

    public void ActiveSuccess()
    {
        _CardAnimator.SetBool("Success", true);

        SoundManager.PlaySound(SoundManager.Sound.Success);

        CurrentStatus = Settings.Status.SUCCESS;
    }
}
