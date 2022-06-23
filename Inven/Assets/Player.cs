using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   private Rigidbody2D playerRigidbody;

   private void Start() 
   {
    playerRigidbody = GetComponent<Rigidbody2D>();
    
   }

   private void Update() 
   {
    loat x = Input.GetAxisRaw("Horizontal");
        playerRigidbody.AddForce(Vector2.right * x, ForceMode2D.Impulse);
    if ()
   }
   
}
