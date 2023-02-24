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
        Others
    }

    static public Color NotMetalColor = new Color(0, 1.0f, 0, 0.8f);
    static public Color DefaultColor = new Color(1, 1, 1, 0.8f);

    static public Color GetMaterialColor(TypeMaterial typeMaterial)
    {
        switch (typeMaterial)
        {
            case TypeMaterial.NotMetal:
                return NotMetalColor;
            
            default:
                return DefaultColor;
        }
    }
}
