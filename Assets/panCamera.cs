using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float totalTime = 0.0f;
    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        float dz = Mathf.Cos(totalTime / 3) / 20;
        transform.position += new Vector3(0, 0, dz);
    }
}
