using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class CardSystem : MonoBehaviour, IPointerClickHandler
{
    const int MAX_ATTEMPT = 5;
    const int AFFECTIVE_CLICK = 1;

    public enum Status
    {
        NONE,
        FAILED,
        SUCCESS
    }

    [SerializeField]
    public Status currentStatus = Status.NONE;

    public string elementSymbol = "H";

    public TMP_Text attemptValueText;
    public TMP_Text elementSymbolText;

    private int currentAttempt = MAX_ATTEMPT;
    private Animator animator;

    /*
        Internal Events
    */

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        SetAttemptText();
        SetElementSymbolText();
    }

    public void OnPointerClick(PointerEventData EventData)
    {
        if (EventData.clickCount == AFFECTIVE_CLICK && currentStatus == Status.NONE) {
            GameManager.Instance.ObjectSelectedCardElement = gameObject;
            TriggerSelected();
        }
    }

    /*
       Generic Functions
    */

    public int CalculateScore()
    {
        // O score é calculado em potência de 2
        return (int)Mathf.Pow(2, currentAttempt);
    }

    public void SetElementSymbolText()
    {
        elementSymbolText.text = elementSymbol;
    }

    public string GetElementSymbolText()
    {
        return elementSymbolText.text;
    }

    public void SetAttemptText()
    {
        attemptValueText.text = this.currentAttempt + "/" + MAX_ATTEMPT;
    }

    public void HitAttempt()
    {
        if(currentStatus == Status.NONE) {
            this.currentAttempt--;

            if(this.currentAttempt <= 0) {
                ActiveFailed();
                this.currentAttempt = 0;
            }
        }
        
        SetAttemptText();
    }

    public void TriggerSelected()
    {
        this.animator.SetTrigger("Selected");
    }

    public void ActiveFailed()
    {
        this.animator.SetBool("Failed", true);
        currentStatus = Status.FAILED;
    }

    public void ActiveSuccess()
    {
        this.animator.SetBool("Success", true);
        currentStatus = Status.SUCCESS;
    }
}
