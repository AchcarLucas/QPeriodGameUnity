using System;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class StructData : ICloneable
{
    public string name;
    public uint game_score;
    public uint game_time;

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}