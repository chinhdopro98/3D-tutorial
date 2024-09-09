using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenerateColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GenerateColor()
    {
        GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }

    public void Reset()
    {
        GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }
}
