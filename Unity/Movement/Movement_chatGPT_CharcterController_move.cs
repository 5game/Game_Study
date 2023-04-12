using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_chatGPT_CharcterController_move : MonoBehaviour
{
    public float speed = 5f; // ĳ���� �̵� �ӵ�

    private CharacterController controller; // ĳ���� ��Ʈ�ѷ� ���� ���

    void Start()
    {
        controller = GetComponent<CharacterController>(); // ĳ���� ��Ʈ�ѷ� ���� ��� ��������
    }

    void Update()
    {
        // �Է� ó��
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // ĳ���� �̵�
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        controller.Move(direction * speed * Time.deltaTime);
    }
}