using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{
    //public float moveSpeed = 5.0f; // �̵� �ӵ�
  public  float moveSpeed = 5.0f; // �̵� �ӵ�

    private Rigidbody rb; // Rigidbody ������Ʈ�� ���� ����

    private void Start()
    {
        // Rigidbody ������Ʈ�� ���� ������ �����ɴϴ�.
      rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // �̵� ������ �Է����� �����ɴϴ�.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        // �̵� ���⿡ �̵� �ӵ��� ���մϴ�.
        Vector3 moveAmount = movement * moveSpeed;

        // Rigidbody�� ����Ͽ� ������Ʈ�� �̵���ŵ�ϴ�.
        rb.velocity = moveAmount;
    }
}