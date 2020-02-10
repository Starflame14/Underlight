using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    float speed = 5f;
    float jumpSpeed = 10.6f;
    float distToGround = 0.5f;

    Rigidbody rb;

    public static bool playerAlive = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        if (playerAlive)
        {
            if (Input.GetAxis("Jump") >= 0.5 && onGround())
            {
                Vector3 jumpVelocity = new Vector3(0f, jumpSpeed, 0f);
                rb.velocity = jumpVelocity;
            }

            Vector3 movement = new Vector3(
                speed * Input.GetAxis("Horizontal") * Time.deltaTime,
                0f,
                speed * Input.GetAxis("Vertical") * Time.deltaTime
            );
            rb.MovePosition(transform.position + movement);

            //animating jumping
            if (onGround())
            {
                if (moving())
                {
                    //animating moving
                }
                else
                {
                    //animating standing
                }
            }
            else
            {
                //animating falling
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Debug.Log("Hit by obstacle");

            playerAlive = false;
        }
    }

    bool onGround()
    {
        return Physics.Raycast(transform.position, Vector3.down, distToGround);
    }

    bool moving()
    {
        return !(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0);
    }
}