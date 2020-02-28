using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllable : MonoBehaviour
{
    [SerializeField]
    private Material red;
    [SerializeField]
    private Material green;
    Renderer myrend;
    // Start is called before the first frame update
    void Start()
    {
        myrend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void select()
    {
       myrend.material = green;
    }

    internal void unselect()
    {
        myrend.material = red;
    }


}
