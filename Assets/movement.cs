using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10.0f * Time.deltaTime;
        Vector3 rotation = new Vector3(speed, -speed, 3 * speed);
        transform.Rotate(rotation);
    }
}
