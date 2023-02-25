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

        elements.Add(new Element(4, 9, 89, "Actídio", "Ac", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(5, 9, 90, "Tório", "Th", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(6, 9, 91, "Protactídio", "Pa", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(7, 9, 92, "Urânio", "U", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(8, 9, 93, "Netúnio", "Np", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(9, 9, 94, "Plutônio", "Pu", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(10, 9, 95, "Amerício", "Am", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(11, 9, 96, "Cúrio", "Cm", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(12, 9, 97, "Berquélio", "Bk", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(13, 9, 98, "Califórnio", "Cf", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(14, 9, 99, "Einsténio", "Es", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(15, 9, 100, "Férmio", "Fm", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(16, 9, 101, "Mendelévio", "Md", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(17, 9, 102, "Nobélio", "No", Settings.TypeMaterial.Actinidia));
        elements.Add(new Element(18, 9, 103, "Laurêncio", "Lr", Settings.TypeMaterial.Actinidia));

        elements.Add(new Element(4, 8, 57, "Lantânio", "La", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(5, 8, 58, "Cério", "Ce", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(6, 8, 59, "Praseodímio", "Pr", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(7, 8, 60, "Neodímio", "Nd", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(8, 8, 61, "Promécio", "Pm", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(9, 8, 62, "Samário", "Sm", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(10, 8, 63, "Európio", "Eu", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(11, 8, 64, "Gadolínio", "Gd", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(12, 8, 65, "Térbio", "Tb", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(13, 8, 66, "Disprósio", "Dy", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(14, 8, 67, "Hólmio", "Ho", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(15, 8, 68, "Érbio", "Er", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(16, 8, 69, "Túlio", "Tm", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(17, 8, 70, "Itérbio", "Yb", Settings.TypeMaterial.Lanthanides));
        elements.Add(new Element(18, 8, 71, "Lutécio", "Lu", Settings.TypeMaterial.Lanthanides));

        return elements;
    }
}
