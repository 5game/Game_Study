using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Test : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name +"감지시작");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name + "감지 중");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + "감지 끝");
    }
}
