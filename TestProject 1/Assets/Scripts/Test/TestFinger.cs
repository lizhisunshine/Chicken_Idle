using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFinger : MonoBehaviour
{
    Vector3 touchPoint = new Vector3 (0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        { 
            Touch touch = Input.GetTouch(0);
            touchPoint = Camera.main.ScreenToWorldPoint(touch.position);
        }
        this.GetComponent<Transform>().position = new Vector3( touchPoint.x,touchPoint.y,0);
    }
}
