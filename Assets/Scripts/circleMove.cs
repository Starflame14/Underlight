using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleMove : MonoBehaviour
{
    private float dir = 0;
    private float radius = 0.03f;
    private float angleSpeed = 1.5f;

    void Start()
    {
    }

    void Update()
    {
        gameObject.transform.position = new Vector3(
            gameObject.transform.position.x + (float) Math.Cos(dir * Math.PI / 180) * radius * angleSpeed,
            gameObject.transform.position.y,
            gameObject.transform.position.z + (float) Math.Sin(dir * Math.PI / 180) * radius * angleSpeed);

        dir += angleSpeed;
    }
}