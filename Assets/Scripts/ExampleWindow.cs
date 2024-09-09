using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExampleWindow : EditorWindow
{
    Color color;
    string myString = "Hello, World!";
    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<ExampleWindow>("Example");
    }
    // Start is called before the first frame update
     void OnGUI() {
        // GUILayout.Label("This is a label", EditorStyles.boldLabel);

        // myString = EditorGUILayout.TextField("Name", myString);
        // if(GUILayout.Button("Press Me"))
        // {
        //     Debug.Log("Press me");
        // }

        GUILayout.Label("Color the selected objects!", EditorStyles.boldLabel);

        color = EditorGUILayout.ColorField("Color", color);

        if(GUILayout.Button("COLORIZE"))
        {
            foreach(GameObject obj in Selection.gameObjects){
                Renderer renderer =  obj.GetComponent<Renderer>();
                if(renderer != null){
                    renderer.sharedMaterial.color = color;
                }
            }
        }


    }
}
