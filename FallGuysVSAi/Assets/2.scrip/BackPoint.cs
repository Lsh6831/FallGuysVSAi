using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPoint : MonoBehaviour
{
     public float spwanPointnumber;
    public Vector3 part1SP1;
    public Vector3 part2SP1;
    public Vector3 part3SP1;
    public Vector3 part3SP2;
    public Vector3 part3SP3;
    public Vector3 part4SP1;

    private void Start()
    {
        spwanPointnumber=1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (spwanPointnumber == 2)
            {
                transform.position = part2SP1;
                Debug.Log("이동2-1");
            }
            else if (spwanPointnumber == 3)
            {
                transform.position = part3SP1;
                Debug.Log("이동3-1");
            }
            else if (spwanPointnumber == 4)
            {
                transform.position = part3SP2;
                Debug.Log("이동3-2");
            }
            else if (spwanPointnumber == 5)
            {
                transform.position = part3SP3;
                Debug.Log("이동3-3");
            }
            else if (spwanPointnumber == 6)
            {
                transform.position = part4SP1;
                Debug.Log("이동4-1");
            }
            else
            {
                transform.position = part1SP1;
            }
        }
    }


    
   private void OnTriggerEnter(Collider other) 
   {
     if(other.tag=="P2SpawnPoint1")
     {
        Debug.Log("2번충돌");
        spwanPointnumber =2;
        
     }
     else if (other.tag=="P3SpawnPoint1")
     {
        spwanPointnumber = 3;
     
     }
     else if (other.tag=="P3SpawnPoint2")
     {
        spwanPointnumber = 4;
     
     }
     else if (other.tag=="P3SpawnPoint3")
     {
        spwanPointnumber = 5;
     
     }
     else if (other.tag=="P4SpawnPoint1")
     {
        spwanPointnumber = 6;
     
     }
     if(other.tag=="Part1Key")
        {
            transform.position=part1SP1;
            Debug.Log("벡ㄱ");

        }
     if(other.tag=="Water")
     {
       
        if(spwanPointnumber==2)
        {
            transform.position=part2SP1;
            Debug.Log("이동2-1");
        }
        else if(spwanPointnumber==3)
        {
            transform.position=part3SP1;
            Debug.Log("이동3-1");
        }
        else if(spwanPointnumber==4)
        {
            transform.position=part3SP2;
            Debug.Log("이동3-2");
        }
        else if(spwanPointnumber==5)
        {
            transform.position=part3SP3;
            Debug.Log("이동3-3");
        }
        else if(spwanPointnumber==6)
        {
            transform.position=part4SP1;
            Debug.Log("이동4-1");
        }
     }
   }
}
