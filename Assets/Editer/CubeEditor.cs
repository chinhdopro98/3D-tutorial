using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Cube cube = (Cube)target;
        base.OnInspectorGUI();
        if(GUILayout.Button("Generate Color"))
        {
            cube.GenerateColor();
        }
         if(GUILayout.Button("Reset"))
        {
            cube.Reset();
        }
    }
}
