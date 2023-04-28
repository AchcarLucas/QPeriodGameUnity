using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnableOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public List<GameObject> ObjectList;
    public List<GameObject> ObjectReverseList;

    public void OnPointerEnter(PointerEventData eventData)
    {
        foreach (GameObject _object in ObjectList)
        {
            _object.SetActive(true);
        }

        foreach (GameObject _object in ObjectReverseList)
        {
            _object.SetActive(false);
        }
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        foreach (GameObject _object in ObjectList)
        {
            _object.SetActive(false);
        }

        foreach (GameObject _object in ObjectReverseList)
        {
            _object.SetActive(true);
        }
    }
}
