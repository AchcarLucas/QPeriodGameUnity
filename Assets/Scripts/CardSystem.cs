using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using TMPro;

public class CardSystem : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    const int MAX_ATTEMPT = 5;

    [SerializeField]
    public Element currentElement;
    public Settings.Status currentStatus = Settings.Status.NONE;
    public Settings.TypeMaterial typeMaterial = Settings.TypeMaterial.Metallic;

    public TMP_Text attemptValueText;
    public TMP_Text elementSymbolText;

    public Image front;

    private int currentAttempt = MAX_ATTEMPT;
    private Animator animator;

    /*
        Internal Events
    */

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();

        ChangeColor();

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

    public void ChangeColor()
    {
        front.color = Settings.GetMaterialColor(typeMaterial);
    }

    public int CalculateScore()
    {
        // O score é calculado em potência de 2
        return (int)Mathf.Pow(2, currentAttempt);
    }

    public void SetElementSymbolText()
    {
        elementSymbolText.text = currentElement.elementSymbol;
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
        if(currentStatus == Settings.Status.NONE) {
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

    public void TriggerUnselected()
    {
        this.animator.SetTrigger("Unselected");
    }

    public void ActiveFailed()
    {
        this.animator.SetBool("Failed", true);
        currentStatus = Settings.Status.FAILED;
    }

    public void ActiveSuccess()
    {
        this.animator.SetBool("Success", true);
        currentStatus = Settings.Status.SUCCESS;
    }
}
