using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{
    //public float moveSpeed = 5.0f; // 이동 속도
  public  float moveSpeed = 5.0f; // 이동 속도

    private Rigidbody rb; // Rigidbody 컴포넌트에 대한 참조

    private void Start()
    {
        // Rigidbody 컴포넌트에 대한 참조를 가져옵니다.
      rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // 이동 방향을 입력으로 가져옵니다.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        // 이동 방향에 이동 속도를 곱합니다.
        Vector3 moveAmount = movement * moveSpeed;

        // Rigidbody를 사용하여 오브젝트를 이동시킵니다.
        rb.velocity = moveAmount;
    }
}