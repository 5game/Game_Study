using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // �̵� �ӵ�
    

    void Update()
    {
        // ������Ʈ�� �̵���ų ������ �����մϴ�.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        // �̵� ���⿡ �̵� �ӵ��� ���Ͽ� ���� �̵����� ����մϴ�.
        Vector3 moveAmount = movement * moveSpeed * Time.deltaTime;

        // Transform�� ����Ͽ� ������Ʈ�� �̵���ŵ�ϴ�.
        transform.Translate(moveAmount);
    }
}
