using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMachine : MonoBehaviour
{
    public GameObject enemyPrefab; // ������ �������
    public float spawnDelay = 2f; // �������� ����� �������
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(SpawnWithCooldown());
        timer += Time.deltaTime; // ����������� ������

        if (timer >= spawnDelay) // ���������, ������ �� ������ ��������
        {
            SpawnEnemy(); // ������� �����
            timer = 0f; // ���������� ������
        }
    }

    private void SpawnEnemy()
    {
        // ��������� ��������� ������� ��� �����
        Vector3 spawnPosition = new Vector3(20, Random.Range(-7.5f, -4f), -1);

        // �������� �����
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
