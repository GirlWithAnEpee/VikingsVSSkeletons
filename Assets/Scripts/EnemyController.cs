using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0.004f, 0f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // если во врага попала пуля - уничтожаем и врага, и пулю

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
