using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_chatGPT_Transform_Position : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        //if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (new Vector3(0,0,1) * speed * Time.deltaTime);
            //transform.position = transform.position + (transform.forward * speed * Time.deltaTime);
            //transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }
}
