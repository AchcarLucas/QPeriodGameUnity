using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Button))]
public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator _Animator;
    private Button _Button;

    public void Start()
    {
        _Animator = gameObject.GetComponent<Animator>();
        _Button = gameObject.GetComponent<Button>();
    }

    public void LateUpdate()
    {
        SetInteractable(_Button.IsInteractable());
    }

    /*
        Mouse Event Hover
    */

    public void OnPointerEnter(PointerEventData eventData)
    {
        SetHover(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        SetHover(false);
    }

    private void SetHover(bool status)
    {
        _Animator.SetBool("Hover", status);
    }

    private void SetInteractable(bool status)
    {
        _Animator.SetBool("Interactable", status);
    }
}