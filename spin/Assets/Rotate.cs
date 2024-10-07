using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    float rotSpeed = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
        }
        transform.Rotate(0,0,rotSpeed);
        rotSpeed *= 0.96f;
    }
}
