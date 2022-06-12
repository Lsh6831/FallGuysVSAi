using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part2Key : MonoBehaviour
{
    private int part2Coin = 0;
    private int maxPart2Coin = 5;
    public int part2Score;
    public GameObject gate2;

    private void Start()
    {
        
    }
  
    private void OnTriggerEnter(Collider other)
    {
        //충동한 상대방 게임 오브젝트가 Coin 태그를 가졌나요?
        if (other.tag == "Coin"&&part2Coin<4)
        {
            part2Coin++;
            other.gameObject.SetActive(false);
        }
        else if(other.tag == "Coin" && part2Coin ==4)
        {
            part2Coin++;
            other.gameObject.SetActive(false);
            gate2.SetActive(false);

        }
        Debug.Log(part2Coin);
        

    }
    //private void CoinCount(int newCoin)
    //{
    //    if(part2Coin<4)
    //    {
    //        part2Coin += newCoin;
    //        Debug.Log(part2Coin);
            
    //    }
    //    else if(part2Score==4)
    //    {
    //        part2Coin += newCoin;
    //    }
        
        
    //}
  
}
