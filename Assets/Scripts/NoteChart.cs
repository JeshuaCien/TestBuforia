using UnityEngine;
using System.Collections.Generic;
using System;
using JetBrains.Annotations;

[Serializable]
public class noteData
{
    public float time;
    public int lane;
}


[Serializable]
public class NoteChart
{
    public List<noteData> notes;
}
