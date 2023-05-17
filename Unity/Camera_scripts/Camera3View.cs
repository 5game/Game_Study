using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3View : MonoBehaviour
{
    Transform playerTransform;
    Vector3 offset;

    private void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        offset = transform.position - playerTransform.position;
    }
    
    private void LateUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}
