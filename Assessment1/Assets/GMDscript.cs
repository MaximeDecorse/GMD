using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMDscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            transform.position += Vector3.up;
        }

        List<Touch> touches = new List<Touch>(Input.touches);

        foreach(Touch touch in touches)
        {
            print(touch.rawPosition + " " + touch.phase + " " + touch.type);
        }
    }
}
