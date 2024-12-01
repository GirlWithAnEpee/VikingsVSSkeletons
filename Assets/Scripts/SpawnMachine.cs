using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMachine : MonoBehaviour
{
    public GameObject enemyPrefab; // Префаб объекта
    public float spawnDelay = 2f; // Задержка между спавном
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //StartCoroutine(SpawnWithCooldown());
        timer += Time.deltaTime; // Увеличиваем таймер

        if (timer >= spawnDelay) // Проверяем, достиг ли таймер задержки
        {
            SpawnEnemy(); // Создаем врага
            timer = 0f; // Сбрасываем таймер
        }
    }

    private void SpawnEnemy()
    {
        // Генерация случайной позиции для врага
        Vector3 spawnPosition = new Vector3(20, Random.Range(-7.5f, -4f), -1);

        // Создание врага
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
