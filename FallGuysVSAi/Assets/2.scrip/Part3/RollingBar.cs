using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBar : MonoBehaviour
{
   public float speed = 1f;
    
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(00, 22, 00) * Time.deltaTime*speed);
    }
}
