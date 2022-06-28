using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CustumButton : MonoBehaviour
{
 
 public void SceneManagement()
 {
    SceneManager.LoadScene("1.MainScene");

 }
    public void OnClick()
    {
        GameObject.Find("Player").GetComponent<PlayerSkin>().HeadRed();
        Debug.Log("클릭");
    }
}
