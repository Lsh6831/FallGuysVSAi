using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part2Key : MonoBehaviour
{
    private int part2Coin = 0;
    public int maxPart2Coin = 5;
    public int part2Score;

    Animator anim;

    private void Start()
    {
        anim=GameObject.Find("Gate2").GetComponent<Animator>();
    }
    // public void Coin()
    // {
    //     float score = 0f;
    //     score++;
       
    //     if(score<4)
    //     {
    //         score++;
    //     }
    // }
  
    private void OnTriggerEnter(Collider other)
    {
        //�浿�� ���� ���� ������Ʈ�� Coin �±׸� ��������?
        if (other.tag == "Coin"&&part2Coin<maxPart2Coin-1)
        {
            part2Coin++;
            Debug.Log("++");
           
        }
        else if(other.tag == "Coin" && part2Coin ==maxPart2Coin-1)
        {
            part2Coin++;
            anim.SetBool("open",true);   
          

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

