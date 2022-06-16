using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part1Key : MonoBehaviour
{
    public GameObject gategard;

    private void OnTriggerEnter(Collider other)
    {
        //충동한 상대방 게임 오브젝트가 Part1Ball 태그를 가졌나요?
        if(other.tag == "Part1Key")
        {
            gategard.SetActive(false);
            Debug.Log("충돌함");

        } 
    }
   
}
