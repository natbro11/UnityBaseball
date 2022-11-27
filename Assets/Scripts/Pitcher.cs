using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitcher : MonoBehaviour
{
    public Pitch FF = new Pitch(new Vector3(-0.95f, 1.64f, 16.82f), new Vector3(3.22f, -0.85f, -40.16f), new Vector3(-5.70f, 9.62f, 9.07f), 2250, 215);
    public Pitch CU = new Pitch(new Vector3(-0.95f, 1.62f, 16.90f), new Vector3(1.48f, -0.52f, -34.69f), new Vector3(4.02f, -9.58f, 6.45f), 2250, 215);
    public Pitch[] pitches = new Pitch[2];


    void Start()
    {
        pitches[0] = FF;
        pitches[1] = CU;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
