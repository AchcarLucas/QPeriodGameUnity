using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Element
{
    public int Column;
    public int Line;
    public int AtomicNumber;

    public string ElementName; 
    public string ElementSymbol;

    public Settings.TypeMaterial TMaterial;

    public Element(
                        int Column, 
                        int Line, 
                        int AtomicNumber, 
                        string ElementName, 
                        string ElementSymbol, 
                        Settings.TypeMaterial TMaterial
                        )
    {
        this.Column = Column;
        this.Line = Line;
        this.AtomicNumber = AtomicNumber;
        this.ElementName = ElementName;
        this.ElementSymbol = ElementSymbol;
        this.TMaterial = TMaterial;
    }
}
