using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0.0002f, 0f, 0f);
    }
}
