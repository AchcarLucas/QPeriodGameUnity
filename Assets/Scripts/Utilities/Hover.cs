using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator _Animator;

    public void Start()
    {
        _Animator = gameObject.GetComponent<Animator>();
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

}