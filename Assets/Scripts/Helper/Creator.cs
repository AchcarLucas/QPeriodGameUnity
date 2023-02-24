using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Creator
{
    public static List<Element> createChemicalElements()
    {
        List<Element> elements = new List<Element>();

        // column, line, atomicNumber, elementName, elementSymbol, typeMaterial
        elements.Add(new Element(1, 1, 1, "Hidrogênio", "H", Settings.TypeMaterial.Gas));

        elements.Add(new Element(18, 1, 2, "Hélio", "He", Settings.TypeMaterial.Gas));
        elements.Add(new Element(18, 2, 10, "Neônio", "Ne", Settings.TypeMaterial.Gas));
        elements.Add(new Element(18, 3, 18, "Argônio", "Ar", Settings.TypeMaterial.Gas));
        elements.Add(new Element(18, 4, 36, "Cripônio", "Kr", Settings.TypeMaterial.Gas));
        elements.Add(new Element(18, 5, 54, "Xenônio", "Xe", Settings.TypeMaterial.Gas));
        elements.Add(new Element(18, 6, 86, "Radônio", "Rn", Settings.TypeMaterial.Gas));
        elements.Add(new Element(18, 7, 118, "Oganessônio", "Og", Settings.TypeMaterial.Gas));

        return elements;
    }
}
