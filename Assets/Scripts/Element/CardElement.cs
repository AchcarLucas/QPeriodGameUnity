using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class CardElement : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    const int MAX_ATTEMPT = 5;

    [SerializeField]
    [Header("Struct Element")]
    public Element OwnStructElement;
    
    [Header("Status Element")]
    public Settings.Status CurrentStatus = Settings.Status.NONE;

    [Header("TMP_Texts Element")]
    public TMP_Text AttemptValueText;
    public TMP_Text ElementSymbolText;

    private int CurrentAttempt = MAX_ATTEMPT;
    private Animator CardAnimator;

    /*
        Internal Events
    */

    void Start()
    {
        CardAnimator = gameObject.GetComponent<Animator>();

        SetAttemptText();
        SetElementSymbolText();
    }

    public void OnSelect(BaseEventData eventData)
    {
        TriggerSelected();
        GameManager.Instance.ObjectSelectedCardElement = gameObject;
    }

    public void OnDeselect(BaseEventData data)
    {
        TriggerUnselected();
        GameManager.Instance.ObjectSelectedCardElement = null;
    }

    /*
       Generic Functions
    */

    public int CalculateScore()
    {
        // O score é calculado em potência de 2
        return (int)Mathf.Pow(2, CurrentAttempt);
    }

    public void SetElementSymbolText()
    {
        ElementSymbolText.text = OwnStructElement.ElementSymbol;
    }

    public string GetElementSymbolText()
    {
        return ElementSymbolText.text;
    }

    public void SetAttemptText()
    {
        AttemptValueText.text = this.CurrentAttempt + "/" + MAX_ATTEMPT;
    }

    public void HitAttempt()
    {
        if(CurrentStatus == Settings.Status.NONE) {
            this.CurrentAttempt--;

            /*
                Se o número de tentativas for alcançado,
                a carta irá simplesmente informar que falhou
            */
            if(this.CurrentAttempt <= 0) {
                ActiveFailed();
                this.CurrentAttempt = 0;
            }
        }
        
        SetAttemptText();
    }

    public void TriggerSelected()
    {
        this.CardAnimator.SetTrigger("Selected");
    }

    public void TriggerUnselected()
    {
        this.CardAnimator.SetTrigger("Unselected");
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
