using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    float timer = 0;
    float distance = 10;

    private MeshRenderer myrend;

    [SerializeField]
    private LayerMask clickablesLayer;

    // Start is called before the first frame update
    void Start()
    {
        myrend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            RaycastHit rayhit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayhit, Mathf.Infinity, clickablesLayer))
            {
                rayhit.collider.GetComponent<Controllable>().select();
            }
        }
    }










        // timer += Time.deltaTime;
/*        if (Input.touchCount > 0)
        {
            *//*            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
                        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                        transform.position = objPosition;*//*
        }*/          
}




/*            List<Touch> touches = new List<Touch>(Input.touches);
            foreach (Touch touch in touches)
            {
                Ray ray = camera.ScreenPointToRay(touch.position);
                Debug.DrawRay(ray.origin, 20 * ray.direction);
                RaycastHit info_on_hit;*/