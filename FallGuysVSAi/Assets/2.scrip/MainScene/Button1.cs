using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button1 : MonoBehaviour
{
    public string sceneName;
    public void Onclick()
    {
        Debug.Log("씬");
        SceneManager.LoadScene(sceneName);
    }
}
