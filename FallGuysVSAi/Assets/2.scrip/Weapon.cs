using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

public float rate; // 공격 속도
public BoxCollider area; // 공격 범위
public TrailRenderer trailEffect;


public void Use()
{
  
    // StopCoroutine("Swing");
    StartCoroutine("Swing");
   
}
IEnumerable Swing()
{
    Debug.Log("사용3");
    yield return new WaitForSeconds(0.1f);
    area.enabled = true;// 콜라이더 활성화
    trailEffect.enabled=true;// 이펙트 활성화;

    yield return new WaitForSeconds(0.3f);

    area.enabled = false;

    yield return new WaitForSeconds(0.3f);
    
    trailEffect.enabled = false;

}


}

