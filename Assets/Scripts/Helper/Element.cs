using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Element
{
    public int column;
    public int line;
    public int atomicNumber;

    public string elementName; 
    public string elementSymbol;

    public Settings.TypeMaterial typeMaterial;

    public Element(
                        int column, 
                        int line, 
                        int atomicNumber, 
                        string elementName, 
                        string elementSymbol, 
                        Settings.TypeMaterial typeMaterial
                        )
    {
        this.column = column;
        this.line = line;
        this.atomicNumber = atomicNumber;
        this.elementName = elementName;
        this.elementSymbol = elementSymbol;
        this.typeMaterial = typeMaterial;
    }
}
