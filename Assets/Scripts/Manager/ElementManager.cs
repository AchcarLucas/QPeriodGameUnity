using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementManager : MonoBehaviour
{
    public static ElementManager Instance;

    // Lista que contém todos os elementos químicos e suas propriedades
    public static List<Element> StructChemicalElements;

    [Header("Prefab Element Table")]
    public GameObject ElementTableTemplate;

    [Header("Max attempt to failed")]
    public int MAX_ATTEMPT_TO_FAILED = 5;

    // Mantém uma referência para a carta de elemento que está selecionada atualmente
    [HideInInspector]
    public GameObject ObjectSelectedCardElement;

    private void Awake()
    {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        
        // StructChemicalElements = Helper.Shuffle(Creator.CreateChemicalElements());
        StructChemicalElements = Creator.CreateChemicalElements();
    }

    /*
        Função responsável por criar o elemento da tabela, destruir o outline correspondente a ele
        e fazer a animação dos elementos de carta
    */
    public bool CreateTableElement(CardElement _CardElement)
    {
        ref Element _Element = ref _CardElement.OwnStructChemicalElement;

        /*
            Procuramos pelo Outline que é do elemento
        */
        string TableOutlineElementName = Settings.BaseNameTableElementOutline + _Element.Column + _Element.Line;
        GameObject TableOutlineObject = GameObject.Find(TableOutlineElementName);

        if(TableOutlineObject == null) {
            Debug.LogError("TableOutlineObject do not exist with name " + TableOutlineElementName);
            return false;
        }

        /*
            Instanciamos o ElementTableTemplate no lugar do Outline
        */
        GameObject TableObject = GameObject.Instantiate(
        ElementTableTemplate,
        TableOutlineObject.transform.parent);

        TableObject.name = Settings.BaseNameTableElement + _Element.Column + _Element.Line;

        TableObject.GetComponent<TableElement>().OwnStructChemicalElement = _Element;

        RectTransform RectTableObject = TableObject.GetComponent<RectTransform>();
        RectTableObject.anchoredPosition = TableOutlineObject.GetComponent<RectTransform>().anchoredPosition;

        /*
            Não precisamos mais do elemento de outline, basta destruir
        */
        Destroy(TableOutlineObject);

        return true;
    }

    public bool IsEndGame()
    {
        GameObject[] ElementCards = GameObject.FindGameObjectsWithTag(Settings.TagNameTableElementOutline);
        return !(ElementCards.Length > 0);
    }
}
