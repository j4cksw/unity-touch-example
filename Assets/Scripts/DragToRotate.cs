using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragToRotate : MonoBehaviour
{
    public bool isActive = false;

    public Color activeColor = new Color();
    
    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            Debug.Log("active");
            activeColor = Color.red;
            
            if (Input.touchCount == 1)
            {
                var screenTouch = Input.GetTouch(0);

                if (screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, -screenTouch.deltaPosition.x/10, 0f);
                }

                if (screenTouch.phase == TouchPhase.Ended)
                {
                    isActive = false;
                }
            }
        }
        else
        {
            activeColor = Color.white;
        }

        GetComponent<MeshRenderer>().material.color = activeColor;
    }
}
