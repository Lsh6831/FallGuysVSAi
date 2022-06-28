using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager m_instance; //싱글턴이 할당될 static 변수

      // 싱글턴 접근용 프로퍼티
    public static GameManager instance
    {
        get
        {
            //만약 싱글턴 변수에 아직 오브젝트가 할당되지 않았다면
            if(m_instance==null)
            {
                // 씬에서 GameManager 오브젝트를 찾아서 할당
                m_instance=FindObjectOfType<GameManager>();
            }
            // 싱글턴 오브젝트 반환
            return m_instance;
        }
    }
    public bool gameStop{get;set;}
    public GameObject menu;
    public int clickCount = 0;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
    {
        clickCount++;
        if(!IsInvoking("DoubleClick"))
        Invoke("DoubleClick",1.0f);
    }
        else if(clickCount==2)
    {
        CancelInvoke("DoubleClick");
        gameStop=true;
        menu.SetActive(true);
        
        
    }
        
    }

    private void DoubleClick()
    {
        clickCount=0;

    }

    

  



}


