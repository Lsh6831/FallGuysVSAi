using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Par1Back : MonoBehaviour
{
    public Vector3 playerTrans;
    private void OnTriggerEnter(Collider collider) 
    {
        
        if(collider.tag=="Part1Key")
        {
            transform.position=playerTrans;
            Debug.Log("벡ㄱ");

        }
        
        
    }
    
}
