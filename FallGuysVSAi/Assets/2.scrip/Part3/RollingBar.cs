using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBar : MonoBehaviour
{
   public float speed = 1f;
    
    private void OnCollisionEnter(Collision other) 
    {
        if(other.transform.CompareTag("Player"))
        {
            Debug.Log("영입");
            other.transform.SetParent(transform);
        }
    }
     private void OnCollisionExit(Collision other) 
    {
        if(other.transform.CompareTag("Player"))
        {
            Debug.Log("방출");
            other.transform.SetParent(null);
        }
    }
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(00, -22, 00) * Time.deltaTime*speed);
    }
}
