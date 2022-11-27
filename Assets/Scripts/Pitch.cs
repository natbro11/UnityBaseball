using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitch : MonoBehaviour
{
    public Vector3 position;
    public Vector3 velocity;
    public Vector3 acceleration;

    public int spinRate;
    public int spinDir;

    void Start()
    {
        transform.position = position;
    }
    void Update()
    {
        transform.position = position;
        velocity.x = velocity.x + Time.deltaTime * acceleration.x;
        velocity.y = velocity.y + Time.deltaTime * acceleration.y;
        velocity.z = velocity.z + Time.deltaTime * acceleration.z;

        position.x = (position.x + Time.deltaTime * velocity.x);
        position.y = (position.y + Time.deltaTime * velocity.y);
        position.z = (position.z + Time.deltaTime * velocity.z);
    }

    public Pitch(Vector3 p, Vector3 v, Vector3 a, int sr, int sd)
    {
        position = p;
        velocity = v;
        acceleration = a;
        spinRate = sr;
        spinDir = sd;
    }
    public Vector3 getPosition()
    {
        return position;
    }
    public Vector3 getVelocity()
    {
        return velocity;
    }
    public Vector3 getAcceleration()
    {
        return acceleration;
    }
}
