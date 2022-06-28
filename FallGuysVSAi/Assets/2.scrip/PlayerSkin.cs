using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkin : MonoBehaviour
{
    public GameObject head;
    Color colHead;
    public float color;

    void Awake() 
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        colHead=head.GetComponent<Renderer>().material.color;
    }
    public void HeadRed()
    {
        head.GetComponent<Renderer>().material.color=Color.red;
    }
    
   
}
