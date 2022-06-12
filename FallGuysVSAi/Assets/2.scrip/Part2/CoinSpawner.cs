using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
  
    //private float timeBetSpawn; //생성 간격

    //private float lastSpawnTime; // 마지막 생성 시점
  
    public GameObject[] prefabs; // 오브젝트 프리펩
                                 
    private BoxCollider area;    //박스콜라이더의 사이즈를 가져오기 위함

    public int count = 100;      //찍어낼 게임 오브젝트 갯수

    private List<GameObject> gameObject = new List<GameObject>();

    void Start()
    {
        area = GetComponent<BoxCollider>();

        for (int i = 0; i < count; ++i)//count 수 만큼 생성한다
        {
            Spawn();//생성
        }

        area.enabled = false;
    }
    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;
        Vector3 size = area.size;

        float posX = basePosition.x + Random.Range(-size.x * 70f, size.x * 70f);
        float posY = basePosition.y + Random.Range(-size.y * 0f, size.y * 0f);
        float posZ = basePosition.z + Random.Range(-size.z * 90f, size.z * 90f);

        Vector3 spawnPos = new Vector3(posX, posY, posZ);

        return spawnPos;
    }
    //해당 함수들은 위 스크립트에 포함되는 함수들임

    private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);

        GameObject selectedPrefab = prefabs[selection];

        Vector3 spawnPos = GetRandomPosition();//랜덤위치함수

        GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        gameObject.Add(instance);
    }
}

