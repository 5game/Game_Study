using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Key_And_Mouse : MonoBehaviour //Ŭ���� �̸��� �ۼ��Ѵ�. Ŭ���� �̸� �� ���� �̸��� ���� �ؾ� �Ѵ�.

//�� ��ũ��Ʈ�� ������Ʈ�� �̵���Ű�� ��ũ��Ʈ �Դϴ�. 
{


    void Start() //��ũ��Ʈ���� �ѹ��� �����Ѵ�(1�����Ӹ� ����)
    {

    }
    
    void Update() // { } ������ �� ������ �����Ѵ�.
    {
        if(Input.GetKeyDown(KeyCode.A)) //���� AŰ�� �����ٸ�
                                        
        {
           transform.Translate(-0.1f, 0, 0); //x������ -0.1f ��ŭ �̵��Ѵ�. y��, z�����δ� �̵����� �ʴ´�.
        }

        if (Input.GetKeyDown(KeyCode.D)) //���� DŰ�� �����ٸ�

        {
            transform.Translate(0.1f, 0, 0); //x������ 0.1f ��ŭ �̵��Ѵ�. y��, z�����δ� �̵����� �ʴ´�.
        }

        if (Input.GetKeyDown(KeyCode.W)) //���� WŰ�� �����ٸ�

        {
            transform.Translate(0, 1.5f, 0); //y������ 1.5f ��ŭ �̵��Ѵ�. x��, z�����δ� �̵����� �ʴ´�.
        }

        if (Input.GetMouseButtonDown(0)) //���콺 ���� ��ư�� ������
        {
            transform.Translate(0, 0, 0.1f); //z������ 0.1f ��ŭ �̵��Ѵ�. x��, y�����δ� �̵����� �ʴ´�.
        }

        if (Input.GetMouseButtonDown(1)) //���콺 ������ ��ư�� ������
        {
            transform.Translate(0, 0, -0.1f); //z������ -0.1f ��ŭ �̵��Ѵ�. x��, y�����δ� �̵����� �ʴ´�.
        }

    }
}
