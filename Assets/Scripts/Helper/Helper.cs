using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Classe 'Helper' é responsável por manter funcionalidades uteis que auxiliam
    nas funções principais do C# como exemplo, shuffle de list.
*/

public static class Helper
{
    public static List<T> Shuffle<T>(this List<T> list)  
    {  
        int n = list.Count;
        while (n > 1) {  
            n--;  
            int k = Random.Range(0, n + 1);
            T value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
        }
        return list;
    }
}