using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_chatGPT_GetAxis_RigidBody : MonoBehaviour
{
    public float speed = 1000.0f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(horizontal, 0, vertical);
        rb.velocity = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        //rb.velocity = movement * speed * Time.deltaTime;
        //rb.AddForce (movement * speed * Time.deltaTime)
    }
}