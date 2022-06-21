using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3Back : MonoBehaviour
{
    public float spwanPointnumber;
    public Vector3 part3SP1;
    public Vector3 part3SP2;
    public Vector3 part3SP3;

    
   private void OnTriggerEnter(Collider other) 
   {
     if(other.tag=="P3SpawnPoint2")
     {
        spwanPointnumber =2;
        
     }
     else if (other.tag=="P3SpawnPoint3")
     {
        spwanPointnumber = 3;
     
     }
     if(other.tag=="Water")
     {
       
        if(spwanPointnumber==3)
        {
            transform.position=part3SP3;
            Debug.Log("이동3");
        }
        else if(spwanPointnumber==2)
        {
            transform.position=part3SP2;
            Debug.Log("이동2");
        }
        else
        {
            transform.position=part3SP1;
            Debug.Log("이동1");
        }
     }
   }
}
