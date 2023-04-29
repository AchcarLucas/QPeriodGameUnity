using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class ButtonSound : MonoBehaviour, IPointerEnterHandler
{
    protected Button _Button;

    public bool SoundOnHover = true;
    public bool SoundOnConfirm = true;

    [ShowWhen("SoundOnHover")]
    public SoundManager.Sound TypeSoundOnHover = SoundManager.Sound.SELECTED;

    [ShowWhen("SoundOnConfirm")]
    public SoundManager.Sound TypeSoundOnConfirm = SoundManager.Sound.CONFIRM_1;

    public void Awake()
    {
        _Button = gameObject.GetComponent<Button>();
        _Button.onClick.AddListener(OnConfirmButton);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(SoundOnHover && _Button.IsInteractable())
            SoundManager.PlaySound(TypeSoundOnHover);
    }

    public void OnConfirmButton()
    {
        if(SoundOnConfirm && _Button.IsInteractable())
            SoundManager.PlaySound(TypeSoundOnConfirm);
    }
}
