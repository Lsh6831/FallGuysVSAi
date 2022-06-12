using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
  
    //private float timeBetSpawn; //���� ����

    //private float lastSpawnTime; // ������ ���� ����
  
    public GameObject[] prefabs; // ������Ʈ ������
                                 
    private BoxCollider area;    //�ڽ��ݶ��̴��� ����� �������� ����

    public int count = 100;      //�� ���� ������Ʈ ����

    private List<GameObject> gameObject = new List<GameObject>();

    void Start()
    {
        area = GetComponent<BoxCollider>();

        for (int i = 0; i < count; ++i)//count �� ��ŭ �����Ѵ�
        {
            Spawn();//����
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
    //�ش� �Լ����� �� ��ũ��Ʈ�� ���ԵǴ� �Լ�����

    private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);

        GameObject selectedPrefab = prefabs[selection];

        Vector3 spawnPos = GetRandomPosition();//������ġ�Լ�

        GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        gameObject.Add(instance);
    }
}

