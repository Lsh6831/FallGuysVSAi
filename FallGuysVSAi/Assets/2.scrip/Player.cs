using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float hAxis;
    float vAxis;
    bool walkDown;
    bool jumpDown;
    bool fireDown;
    bool isFireReady = true;
    bool isBorder;

    bool isJump;
    bool isDodge;

    public float speed = 20f;
    public float jumpForse = 100f;
    float fireDelay;

    Rigidbody rigid;
    Animator anim;

    

    
    Vector3 moveVec;
    Vector3 dodgeVec;

    Weapon equipWeapon;

    float rate2;

  
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
        rate2 = GameObject.Find("Weapon Hammer").GetComponent<Weapon>().rate;
    }

    
    void Update()
    {
        GetInput();
        Move();
        Turn();
        Jump();
        Attack();
        Dodge();
        
    }

    void GetInput()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        walkDown = Input.GetButton("Walk");
        jumpDown = Input.GetButtonDown("Jump");
        fireDown = Input.GetButtonDown("Fire1");

    }
    void Move()
    {
        moveVec = new Vector3(hAxis,0,vAxis).normalized;

        if(isDodge)
        {
            moveVec = dodgeVec;
        }
        if(!isFireReady)
        {
            moveVec = Vector3.zero;
        }
        if(!isBorder)
        {
        transform.position += moveVec * speed *(walkDown ? 0.3f:1f) * Time.deltaTime;
        //                                      삼항연산자
        }

        anim.SetBool("isRun",moveVec !=Vector3.zero);
        anim.SetBool("isWalk",walkDown);

    }
    void Turn()
    {
        transform.LookAt(transform.position+moveVec);
        // 회전 구현(나아가는 방향으로 바라본다
    }

    void Jump()
    {
        if(jumpDown&& moveVec == Vector3.zero &&!isJump&& !isDodge)
        {
            rigid.AddForce(Vector3.up*jumpForse,ForceMode.Impulse);
            //                                  즉시발동
            anim.SetBool("isJump",true);
            anim.SetTrigger("doJump");
            isJump = true;
        }
    }

    void Attack()
    {
        fireDelay += Time.deltaTime;    
        // isFireReady = equipWeapon.rate < fireDelay;
        isFireReady = rate2 < fireDelay;

        if(fireDown && isFireReady && !isDodge)
        {
            
            // equipWeapon.Use();
            GameObject.Find("Weapon Hammer").GetComponent<Weapon>().Use();
            anim.SetTrigger("doSwing");
            fireDelay=0;
        }
    }
     void Dodge()
    {
        if(jumpDown&& moveVec != Vector3.zero&&!isJump&&!isDodge)
        {
            dodgeVec = moveVec;
            speed *= 2;
            anim.SetTrigger("doDodge");
            isDodge = true;

            Invoke("DodgeOut",0.5f);
            // 시간차 주기 ""안에 넣어야함 , 시간
        }
    }

    void DodgeOut()
    {
        speed *=0.5f;
        isDodge =false;
    }
    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag=="Floor")
        {
            anim.SetBool("isJump",false);
            isJump = false;
        }
    }
      private void FixedUpdate() 
    {
        StopToWall();
    }
    void StopToWall()
    {
        Debug.DrawRay(transform.position, transform.forward*2,Color.green);
        isBorder = Physics.Raycast(transform.position,transform.forward,2,LayerMask.GetMask("Wall"));
    }
}
