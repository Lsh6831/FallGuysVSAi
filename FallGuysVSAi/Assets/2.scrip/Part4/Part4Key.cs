using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part4Key : MonoBehaviour
{
    public GameObject gameOver;
    
    private void Awake()
    {
        gameOver.SetActive(false);
    }
  private void OnTriggerEnter(Collider other) 
  {
   if(other.tag=="Ball")
   {
    gameOver.SetActive(true);
    Debug.Log("게임종료");
   } 
  }
}
