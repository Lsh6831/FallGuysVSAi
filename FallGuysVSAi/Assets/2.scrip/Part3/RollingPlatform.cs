using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingPlatform : MonoBehaviour
{
    public float speed = 1f;
    
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, 22) * Time.deltaTime*speed);
    }
}
