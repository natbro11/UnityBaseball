using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ball;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject a = Instantiate(ball);
            Projectile p1 = a.GetComponent<Projectile>();
            p1.set(new Vector3(-0.8f, 1.8f, 16.8f), new Vector3(2.0f, -0.3f, -40.5f), new Vector3(-3.3f, -5.7f, 8.4f), 2250, 215);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject b = Instantiate(ball);
            Projectile p2 = b.GetComponent<Projectile>();
            p2.set(new Vector3(-0.8f, 1.8f, 16.8f), new Vector3(2.0f, -0.3f, -35.0f), new Vector3(3.7f, -12.0f, 7.5f), 2250, 215);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject c = Instantiate(ball);
            Projectile p3 = c.GetComponent<Projectile>();
            p3.set(new Vector3(-0.8f, 1.8f, 16.8f), new Vector3(2.0f, -0.3f, -37.0f), new Vector3(-3.9f, -9.1f, 6.5f), 2250, 215);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject d = Instantiate(ball);
            Projectile p4 = d.GetComponent<Projectile>();
            p4.set(new Vector3(-0.8f, 1.8f, 16.8f), new Vector3(2.0f, -0.3f, -37.0f), new Vector3(0.7f, -9.5f, 6.9f), 2250, 215);
        }

        
    }
}
