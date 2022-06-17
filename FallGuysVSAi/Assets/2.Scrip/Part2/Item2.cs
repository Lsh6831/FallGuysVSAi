using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item2 : MonoBehaviour
{
    public float speed = 4f;
    public GameObject particle;
        
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(00, 22, 0) * Time.deltaTime*speed);
    }   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            // StopCoroutine("Particle");
            // StartCoroutine("Particle");
            Debug.Log("충돌");

            particle.SetActive(true);
            gameObject.SetActive(false);
            Invoke("ParticleStop",3f);
            Invoke("Regen",6f); 
        }
    }   
    public void ParticleStop()
    {
        particle.SetActive(false);
    }

    public void Regen()
    {
         gameObject.SetActive(true);
    }
    // IEnumerator Particle()
    // {
    //     particle.SetActive(true);
    //     Debug.Log("파티클 ㄱ");
    //     yield return new WaitForSeconds(0.9f);
    //     Debug.Log("파티클 ㄴㄴ");
    //     particle.SetActive(false);
    //     yield return new WaitForSeconds(3f);
    //     gameObject.SetActive(true);

    // }

    }
