using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Sphere))]
public class SphereEditor : Editor
{
    // Start is called before the first frame update

    // Update is called once per frame
    public override void OnInspectorGUI(){
        base.OnInspectorGUI();
        Sphere sphere = (Sphere)target;
        sphere.baseSize = EditorGUILayout.Slider("Size", sphere.baseSize, .1f, 2f);
        sphere.transform.localScale = Vector3.one * sphere.baseSize;
    }
}
