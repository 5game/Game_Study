using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_chatGPT_CharcterController_move : MonoBehaviour
{
    public float speed = 5f; // 캐릭터 이동 속도

    private CharacterController controller; // 캐릭터 컨트롤러 구성 요소

    void Start()
    {
        controller = GetComponent<CharacterController>(); // 캐릭터 컨트롤러 구성 요소 가져오기
    }

    void Update()
    {
        // 입력 처리
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 캐릭터 이동
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        controller.Move(direction * speed * Time.deltaTime);
    }
}