using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using TMPro;

[CustomEditor(typeof(SortingLayerTMPText))]
public class SortingLayerTextTMPEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        SortingLayerTMPText script = (SortingLayerTMPText)target;

        script.SortingOrder = EditorGUILayout.IntField("Sorting Order", script.SortingOrder);

        TextMeshProUGUI t = script.gameObject.GetComponent<TextMeshProUGUI>();

        if (t != null)
            t.canvas.sortingOrder = script.SortingOrder;
    }
}