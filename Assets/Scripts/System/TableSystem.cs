using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSystem : MonoBehaviour
{
    [SerializeField]
    [Header("Child Elements Transform")]
    public Transform ElementChildObject;
    public Transform ElementOutlineChildObject;

    [Header("Prefab Elements Table")]
    public GameObject ElementTableTemplate;
    public GameObject ElementTableOutlineTemplate;

    private ElementManager EManager = ElementManager.Instance;

    public void Awake()
    {
        List<Element> StructChemicalElements = ElementManager.StructChemicalElements;
        
        Debug.Log("Instantiate " + StructChemicalElements.Count + " element(s) table and outline");

        RectTransform RectTransformTemplate = ElementTableOutlineTemplate.GetComponent<RectTransform>();
        Rect RectTemplate = RectTransformTemplate.rect;
        Vector2 LocalScaleTemplate = RectTransformTemplate.localScale;

        foreach(Element StructChemicalElement in StructChemicalElements) {
            GameObject TableOutlineObject = GameObject.Instantiate(
                    ElementTableOutlineTemplate,
                    ElementOutlineChildObject);

            RectTransform AnchoredObject = TableOutlineObject.GetComponent<RectTransform>();

            AnchoredObject.anchoredPosition = new Vector2(
                (RectTemplate.width + 10) * LocalScaleTemplate.x * (StructChemicalElement.Column - 1),
                (-1) * (RectTemplate.height + 10) * LocalScaleTemplate.y * (StructChemicalElement.Line - 1));

            Debug.Log(AnchoredObject.anchoredPosition);
            
        }
    }
}
