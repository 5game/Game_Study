using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_and_Color_Change : MonoBehaviour //클래스 이름을 작성한다. 클래스 이름 과 파일 이름은 동일 해야 한다.

    //이 스크립트는 오브젝트가 이동을 하면 머티리얼 색상이 바뀌는 스크립트 이다.
{
    Material material_Color; //머티리얼 색상을 바꿀 변수

    void Start() //스크립트에서 한번만 실행한다(1프레임만 실행)
    {
        material_Color = gameObject.GetComponent<MeshRenderer>().material; //게임오브젝트의 매쉬랜더러 컴포넌트 와 머티리얼 속성을 meterial_Color 변수에 대입
    }

    
    void Update() // { } 내용은 매 프레임 실행한다.
    {
        if(Input.GetKeyDown(KeyCode.A)) //만약 A키를 눌렀다면 
        {
            transform.Translate(-0.1f, 0, 0); //x축으로 -0.1f 만큼 이동한다. y축, z축으로는 이동하지 않는다.
            //material_Color.material.color = new Color (255 / 255f, 0 / 255f, 0 / 255f);
            //material_Color.material.color = Color.red;
            material_Color.color = new Color (1,0,0);
        }
        if (Input.GetKeyDown(KeyCode.D)) //만약 D키를 눌렀다면
        {
            transform.Translate(0.1f, 0, 0); //x축으로 0.1f 만큼 이동한다. y축, z축으로는 이동하지 않는다.
        }
        if (Input.GetKeyDown(KeyCode.W)) //만약 W키를 눌렀다면
        {
            transform.Translate(0, 0, 0.1f); //z축으로 0.1f 만큼 이동한다. x축, y축으로는 이동하지 않는다.
        }
        if (Input.GetKeyDown(KeyCode.S)) //만약 S키를 눌렀다면
        {
            transform.Translate(0, 0, -0.1f); //z축으로 -0.1f 만큼 이동한다. x축, y축으로는 이동하지 않는다.
        }

    }
}
