using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Classe 'Creator' é responsável pela inicialização de estruturas essenciais 
    que serão usados ao longo do jogo.
    OBS: poderia ser feito direto pelo editor da unity, porém, achei melhor 
    ter essa classe estática para fazer isso por mim.
*/

public static class Creator
{
    public static List<Element> CreateChemicalElements()
    {
        Debug.Log("[Creator] - CreateChemicalElements");

        List<Element> elements = new List<Element>();

        // column, line, atomicNumber, elementName, elementSymbol, typeMaterial
        elements.Add(new Element(1, 1, 1, "Hidrogênio", "H", Settings.TypeMaterial.NotMetal));

        elements.Add(new Element(1, 2, 3, "Lítio", "Li", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 3, 11, "Sódio", "Na", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 4, 19, "Potássio", "K", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 5, 37, "Rubídio", "Rb", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 6, 55, "Césio", "Cs", Settings.TypeMaterial.AlkalineMetal));
        elements.Add(new Element(1, 7, 87, "Frâncio", "Fr", Settings.TypeMaterial.AlkalineMetal));

        elements.Add(new Element(18, 1, 2, "Hélio", "He", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 2, 10, "Neônio", "Ne", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 3, 18, "Argônio", "Ar", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 4, 36, "Cripônio", "Kr", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 5, 54, "Xenônio", "Xe", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 6, 86, "Radônio", "Rn", Settings.TypeMaterial.NobleGases));
        elements.Add(new Element(18, 7, 118, "Oganessônio", "Og", Settings.TypeMaterial.NobleGases));


        elements.Add(new Element(4, 9, 2, "Actídio", "Ac", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(5, 9, 10, "Tório", "Th", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(6, 9, 18, "Protactídio", "Pa", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(7, 9, 36, "Urânio", "U", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(8, 9, 54, "Netúnio", "Np", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(9, 9, 86, "Plutônio", "Pu", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(10, 9, 118, "Amerício", "Am", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(11, 9, 118, "Cúrio", "Cm", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(12, 9, 118, "Berquélio", "Bk", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(13, 9, 118, "Califórnio", "Cf", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(14, 9, 118, "Einsténio", "Es", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(15, 9, 118, "Férmio", "Fm", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(16, 9, 118, "Mendelévio", "Md", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(17, 9, 118, "Nobélio", "No", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(18, 9, 118, "Laurêncio", "Lr", Settings.TypeMaterial.Actinidia));

        return elements;
    }
}
