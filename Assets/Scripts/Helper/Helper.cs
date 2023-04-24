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

    // https://stackoverflow.com/questions/42468014/creating-a-name-generator-for-unity-project-c-sharp
    public static string GenerateRandomName()
    {
        System.Random r = new System.Random();

        string[] NameComponentFirst = new string[] {"Ge","Me","Ta","Bo","Ke","Ra","Ne","Mi","To","San","Pee"};
        string[] NameComponentSecond = new string[] {"oo","ue","as","to","ra","me","io","so","tu","da","mi"};
        string[] NameComponentThird = new string[] {"se","matt","lace","fo","cake","end","caa"};

        string Name = NameComponentFirst[r.Next(0, NameComponentFirst.Length - 1)];
        Name += NameComponentSecond[r.Next(0, NameComponentSecond.Length - 1)];
        Name += NameComponentThird[r.Next(0, NameComponentThird.Length - 1)];

        return Name;
    }
}