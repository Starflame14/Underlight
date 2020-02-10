using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    float x;
    float speed = 5f;

    void Start()
    {
    }

    void Update()
    {
        if (playerMove.playerAlive)
        {
            x = Input.GetAxis("RightVertical");

            Vector3 move = new Vector3(0, 0, x);

            gameObject.transform.Translate(move.normalized * (Time.deltaTime * speed));
        }
        else
        {
            gameObject.transform.position = new Vector3(0, 1000, 0);
        }
    }
}