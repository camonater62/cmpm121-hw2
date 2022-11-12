using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchCamera : MonoBehaviour
{
    public Camera[] cameras;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Camera c in cameras)
        {
            c.enabled = false;
        }
        cameras[0].enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            EnableCamera(0);
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            EnableCamera(1);
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            EnableCamera(2);
        }
    }

    void EnableCamera(int n) {
        foreach (Camera c in cameras)
        {
            c.enabled = false;
        }
        cameras[n].enabled = true;
    }
}
