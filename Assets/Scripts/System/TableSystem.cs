using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TableSystem : MonoBehaviour
{
    const int MAX_GROUP = 18;
    const int MAX_FAMILY = 7;

    [SerializeField]
    [Header("Child Elements Transform")]
    public Transform ElementChildObject;
    public Transform ElementOutlineChildObject;
    public Transform DigitTextChildObject;

    [Header("Prefab Elements Table")]
    public GameObject ElementTableTemplate;
    public GameObject ElementTableOutlineTemplate;
    public GameObject DigitTextTemplate;

    private ElementManager EManager = ElementManager.Instance;

    private List<Element> StructChemicalElements;

    public void Awake()
    {
        StructChemicalElements = ElementManager.StructChemicalElements;
        DrawPeriodTable();
    }

    public void DrawPeriodTable()
    {
        /*
            A escala do ElementTableTemplate e do ElementTableOutlineTemplate
            portanto pode ser utilizado o mesmo rect e o mesmo localScale
        */
        RectTransform RectTransformTemplate = ElementTableOutlineTemplate.GetComponent<RectTransform>();
        Rect RectTemplate = RectTransformTemplate.rect;
        Vector2 LocalScaleTemplate = RectTransformTemplate.localScale;

        /*
            Montamos os elementos da tabela periódico
        */

        foreach(Element StructChemicalElement in StructChemicalElements) {
            GameObject TableOutlineObject = GameObject.Instantiate(
                    ElementTableOutlineTemplate,
                    ElementOutlineChildObject);

            TableOutlineObject.GetComponent<TableOutlineElement>().OwnStructChemicalElement = StructChemicalElement;

            RectTransform RectTableOutlineObject = TableOutlineObject.GetComponent<RectTransform>();

            RectTableOutlineObject.anchoredPosition = new Vector2(
                (RectTemplate.width + 10) * LocalScaleTemplate.x * (StructChemicalElement.Column - 1),
                (-1) * (RectTemplate.height + 10) * LocalScaleTemplate.y * (StructChemicalElement.Line - 1));
        }

        /*
            Desenha a numeração do grupo
        */
        for(int GroupIndex = 0; GroupIndex < MAX_GROUP; ++GroupIndex) {
            GameObject DigitObject = GameObject.Instantiate(DigitTextTemplate, DigitTextChildObject);

            TMP_Text DigitText = DigitObject.GetComponent<TMP_Text>();
            RectTransform RectText = DigitObject.GetComponent<RectTransform>();

            DigitText.text = (GroupIndex + 1).ToString();

            float RealWidthElement = RectTemplate.width * LocalScaleTemplate.x;

            RectText.anchoredPosition = new Vector2(
                    (RealWidthElement / 2) + (RealWidthElement + (10 * LocalScaleTemplate.x)) * GroupIndex, 
                    RectText.anchoredPosition.y + 25.0f
                );
        }


        /*
            Desenha a numeração da familia
        */
        for(int FamilyIndex = 0; FamilyIndex < MAX_FAMILY; ++FamilyIndex) {
            GameObject DigitObject = GameObject.Instantiate(DigitTextTemplate, DigitTextChildObject);

            TMP_Text DigitText = DigitObject.GetComponent<TMP_Text>();
            RectTransform RectText = DigitObject.GetComponent<RectTransform>();

            DigitText.text = (FamilyIndex + 1).ToString();

            float RealHeightElement = RectTemplate.height * LocalScaleTemplate.y;

            RectText.anchoredPosition = new Vector2(
                    RectText.anchoredPosition.x - 30.0f,
                    (-1) * ((RealHeightElement / 2) + (RealHeightElement + (10 * LocalScaleTemplate.y)) * FamilyIndex)
                );
        }

        Debug.Log("Instantiate " + StructChemicalElements.Count + " element(s) table and outline");
    }
}
