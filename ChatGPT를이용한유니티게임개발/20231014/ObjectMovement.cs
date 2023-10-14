using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 이동 속도
    

    void Update()
    {
        // 오브젝트를 이동시킬 방향을 설정합니다.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);

        // 이동 방향에 이동 속도를 곱하여 실제 이동량을 계산합니다.
        Vector3 moveAmount = movement * moveSpeed * Time.deltaTime;

        // Transform을 사용하여 오브젝트를 이동시킵니다.
        transform.Translate(moveAmount);
    }
}
