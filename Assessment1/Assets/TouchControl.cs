using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    float timer = 0;
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.touchCount > 0)
        {
            List<Touch> touches = new List<Touch>(Input.touches);
            foreach (Touch touch in touches)
            {
                Ray ray = camera.ScreenPointToRay(touch.position);
                Debug.DrawRay(ray.origin, 20 * ray.direction);
                RaycastHit info_on_hit;
            }
        }
            
    }
}
