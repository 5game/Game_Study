using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_variable : MonoBehaviour //클래스 이름을 작성한다. 클래스 이름 과 파일 이름은 동일 해야 한다.

//이 스크립트는 변수를 이용해서 오브젝트를 이동 시키는 스크립트 입니다.
{
    public float tran_Var = 0; //오브젝트의 위치를 이동 시킬 퍼블릭 변수;

    void Start() //스크립트에서 한번만 실행한다(1프레임만 실행)
    {

    }
    
    void Update() // { } 내용은 매 프레임 실행한다.
    {
        if(Input.GetKeyDown(KeyCode.A)) //만약 A키를 눌렀다면
                                        
        {
           transform.Translate(-tran_Var, 0, 0); //x축으로 -0.1f 만큼 이동한다. y축, z축으로는 이동하지 않는다.
        }

        if (Input.GetKeyDown(KeyCode.D)) //만약 D키를 눌렀다면

        {
            transform.Translate(tran_Var, 0, 0); //x축으로 0.1f 만큼 이동한다. y축, z축으로는 이동하지 않는다.
        }

        if (Input.GetKeyDown(KeyCode.W)) //만약 W키를 눌렀다면
        {
            transform.Translate(0, 0, tran_Var); //z축으로 0.1f 만큼 이동한다. x축, y축으로는 이동하지 않는다.
        }

        if (Input.GetKeyDown(KeyCode.S)) //만약 S키를 눌렀다면
        {
            transform.Translate(0, 0, -tran_Var); //z축으로 -0.1f 만큼 이동한다. x축, y축으로는 이동하지 않는다.
        }

    }
}
