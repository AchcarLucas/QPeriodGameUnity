using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings
{
    public enum Status
    {
        NONE,
        FAILED,
        SUCCESS
    }

    public enum TypeMaterial
    {
        Default,
        NotMetal,
        NobleGases,
        AlkalineMetal,
        AlkalineEarthMetal,
        SemiMetal,
        Halogens,
        TransitionMetal,
        Actinidia,
        Lanthanides,
        OthersMetal
    }

    static public Color NotMetalColor = new Color32(161, 211, 68, 255);
    static public Color NobleGasesColor = new Color32(39, 147, 224, 255);
    static public Color AlkalineMetalColor = new Color32(241, 178, 0, 255);
    static public Color AlkalineEarthMetalColor = new Color32(234, 218, 0, 255);
    static public Color TransitionMetalColor = new Color32(235, 142, 142, 255);
    static public Color LanthanidesColor = new Color32(144, 227, 233, 255);
    static public Color ActinidiaColor = new Color32(220, 173, 214, 255);
    static public Color OthersMetalColor = new Color32(162, 199, 211, 255);
    static public Color SemiMetalColor = new Color32(77, 182, 172, 255);
    static public Color HalogensColor = new Color32(112, 203, 235, 255);
    static public Color DefaultColor = new Color32(255, 255, 255, 255);

    static public Color GetMaterialColor(TypeMaterial typeMaterial)
    {
        switch (typeMaterial)
        {
            case TypeMaterial.NotMetal:
                return NotMetalColor;

            case TypeMaterial.NobleGases:
                return NobleGasesColor;

            case TypeMaterial.AlkalineMetal:
                return AlkalineMetalColor;

            case TypeMaterial.AlkalineEarthMetal:
                return AlkalineEarthMetalColor;

            case TypeMaterial.Actinidia:
                return ActinidiaColor;

            case TypeMaterial.TransitionMetal:
                return TransitionMetalColor;
                
            case TypeMaterial.Lanthanides:
                return LanthanidesColor;

            case TypeMaterial.SemiMetal:
                return SemiMetalColor;

            case TypeMaterial.OthersMetal:
                return OthersMetalColor;
                
            case TypeMaterial.Halogens:
                return HalogensColor;

            default:
                return DefaultColor;
        }
    }
}
