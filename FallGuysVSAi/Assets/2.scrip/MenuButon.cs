using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButon : MonoBehaviour
{

public void OnclickAgain()
{
    GameManager.instance.clickCount=0;
    GameManager.instance.menu.SetActive(false);
    // menuBox.SetActive(false);
    GameManager.instance.gameStop=false;
}
public void OnclickReStart()
{
    GameManager.instance.menu.SetActive(false);
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    GameManager.instance.gameStop=false;
}
public void OnclickMenuScen()
{
     GameManager.instance.menu.SetActive(false);
    SceneManager.LoadScene("1.MainScene");
}
public void OnclickExit()
{
     GameManager.instance.menu.SetActive(false);
    Debug.Log("게임종료");
    SceneManager.LoadScene("1.MainScene");
}

}
