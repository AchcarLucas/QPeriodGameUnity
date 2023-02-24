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
        Metallic,
        Radioactive,
        Liquid,
        Gas
    }

    static public Color MetallicColor = new Color(0, 0, 0, 0.8f);
    static public Color RadioactiveColor = new Color(0, 1, 0, 0.8f);
    static public Color LiquidColor = new Color(0, 0.36f, 1, 0.8f);
    static public Color GasColor = new Color(1, 0.8f, 0, 0.8f);
    static public Color Default = new Color(1, 1, 1, 0.8f);

    static public Color GetMaterialColor(TypeMaterial typeMaterial)
    {
        switch (typeMaterial)
        {
            case TypeMaterial.Metallic:
                return MetallicColor;
            case TypeMaterial.Radioactive:
                return RadioactiveColor;
            case TypeMaterial.Liquid:
                return LiquidColor;
            case TypeMaterial.Gas:
                return GasColor;
            default:
                return Default;
        }
    }
}
