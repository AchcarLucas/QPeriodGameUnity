using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnableOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> ObjectActiveList;
    public List<GameObject> ObjectReverseActiveList;

    public void OnPointerEnter(PointerEventData eventData)
    {
        foreach (GameObject _object in ObjectActiveList)
        {
            _object.SetActive(true);
        }

        foreach (GameObject _object in ObjectReverseActiveList)
        {
            _object.SetActive(false);
        }
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        foreach (GameObject _object in ObjectActiveList)
        {
            _object.SetActive(false);
        }

        foreach (GameObject _object in ObjectReverseActiveList)
        {
            _object.SetActive(true);
        }
    }
}
