using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // 싱글턴을 할당항 전역 변수
    public bool isGameover;
    public GameObject part2Gate;
    private int part2Coin = 0;
    

    public void Part2Coin(int newcount)
    {
        part2Coin += newcount;

        if(part2Coin==5)
        {
            part2Gate.SetActive(false);
        }
        
      
    }



}


