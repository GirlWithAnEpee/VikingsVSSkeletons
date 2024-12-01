using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab; // Префаб объекта
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(bulletPrefab, transform.position, transform.rotation);
            b.GetComponent<Rigidbody2D>().AddForce(new Vector3(7, 0, 0), ForceMode2D.Impulse);
        } else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            Vector3 delta = new Vector3(0f, 0.15f, 0f);
            if (transform.position.y + delta.y <= -4f)
            {
                transform.position += delta;
            }   
        } else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            Vector3 delta = new Vector3(0f, 0.15f, 0f);
            if (transform.position.y - delta.y >= -7.5f)
            {
                transform.position -= delta;
            }
        }
    }
}
