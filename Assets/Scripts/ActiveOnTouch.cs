using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveOnTouch : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            
            var ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("hit");
                if (hit.transform.tag == "cubes")
                {
                    Debug.Log("cube");
                    var rotation = hit.collider.GetComponent<DragToRotate>();
                    rotation.isActive = true;
                }
            }
        }
    }
}
