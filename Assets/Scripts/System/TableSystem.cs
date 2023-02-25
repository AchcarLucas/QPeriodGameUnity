using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSystem : MonoBehaviour
{
    [SerializeField]
    [Header("Child Elements Object")]
    public GameObject ElementChildObject;
    public GameObject ElementOutlineChildObject;

    [Header("Prefab Elements Table")]
    public GameObject ElementTableTemplate;
    public GameObject ElementTableOutlineTemplate;

    private ElementManager EManager = ElementManager.Instance;

    public void Awake()
    {

    }
}
