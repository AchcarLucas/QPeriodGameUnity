using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Creator
{
    public static List<Element> createElements()
    {
        List<Element> elements = new List<Element>();

        // column, line, atomicNumber, elementName, elementSymbol, typeMaterial
        elements.Add(new Element(0, 0, 1, "Hidrogênio", "H", Settings.TypeMaterial.Gas));

        return elements;
    }
}
