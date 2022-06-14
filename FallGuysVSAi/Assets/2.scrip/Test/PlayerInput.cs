using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    public string moveAxisName = "Vertical"; //앞뒤 움직임을 위한 입력축 이름
    public string rotareAxisName = "Horizontal"; //좌우 회전을 위한 입력축 이름
    // public string jumpAxisName = "Jump";// 점프 를 위한 입력축이름

    private int jumpCount = 0; // 점프 횟수
    private Rigidbody playerRigidbody;
    public float jumpForce = 700f; // 점프
   
    

    public float move { get; private set; } // 감지된 움직임 입력값
    public float rotate { get; private set; }// 감지된 회전 입력값
    // public float jump {get;private set;}// 감지된 점프 입력값
    
    

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //게임오버 상태에서는 사용자 입력을 감지하지 않음
    if(GameManager.instance!=null && GameManager.instance.isGameover)
        {
            move = 0;
            rotate = 0;
           
          
            return;
        }
    // 프로퍼티**
        //move에 관한 입력 감지
        move = Input.GetAxis(moveAxisName);
        //rotate 에 관한 입력감지
        rotate = Input.GetAxis(rotareAxisName);
        //jump 에 관한 입력감지
        // jump =Input.GetAxisRaw(jumpAxisName);
    if(Input.GetKeyDown(KeyCode.Space))
    {
         

            playerRigidbody.velocity = Vector2.zero;

           
            playerRigidbody.AddForce(new Vector2(0, jumpForce));
            Debug.Log("점프");
    }
       
        
    if(Input.GetKeyDown(KeyCode.LeftShift))
        {
           GameObject.Find("Player").GetComponent<PlayerMovement>().moveSpeed=25f;
        }  
    if(Input.GetKeyUp(KeyCode.LeftShift))
    {
        GameObject.Find("Player").GetComponent<PlayerMovement>().moveSpeed=15f;
    }

    }


}
