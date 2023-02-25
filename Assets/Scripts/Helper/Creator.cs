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

        return elements;
    }
}
