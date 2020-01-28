using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllable : MonoBehaviour
{
    Renderer my_renderer;
    // Start is called before the first frame update
    void Start()
    {
        my_renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void select()
    {
        my_renderer.material.color = Color.yellow;
    }

    internal void unselect()
    {
        my_renderer.material.color = Color.white;
    }


}
