using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Test : MonoBehaviour
{  
        
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹 ����");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 ��");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹 ��");
    }
}
