using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            transform.position = new Vector3(1, 2, 0);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            transform.position = new Vector3(0, 1, -2);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            transform.position = new Vector3(-1, 2, 0);
        }
    }
}
