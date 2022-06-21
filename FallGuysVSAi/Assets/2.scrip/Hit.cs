using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    Rigidbody rigid;
    CapsuleCollider capsuleCollider;
    public float howLong;


private void Awake() 
{
    rigid = GetComponent<Rigidbody>();
    capsuleCollider = GetComponent<CapsuleCollider>();
}
    void OnTriggerEnter(Collider other) 
    {
        if(other.tag=="Hamma")
        {
            Vector3 reactVec = transform.position - other.transform.position;
            
            OnHit(reactVec);
            
        }
    } 
    void OnHit(Vector3 reactVec)
    {
        reactVec = reactVec.normalized;
        reactVec += Vector3.up;

        rigid.AddForce(reactVec*howLong,ForceMode.Impulse);
        // 넉백량 = * ,                    즉발적인 힘

    }
   
}

