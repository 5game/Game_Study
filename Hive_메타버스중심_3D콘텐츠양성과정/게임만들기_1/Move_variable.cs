using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_variable : MonoBehaviour //Ŭ���� �̸��� �ۼ��Ѵ�. Ŭ���� �̸� �� ���� �̸��� ���� �ؾ� �Ѵ�.

//�� ��ũ��Ʈ�� ������ �̿��ؼ� ������Ʈ�� �̵� ��Ű�� ��ũ��Ʈ �Դϴ�.
{
    public float tran_Var = 0; //������Ʈ�� ��ġ�� �̵� ��ų �ۺ� ����;

    void Start() //��ũ��Ʈ���� �ѹ��� �����Ѵ�(1�����Ӹ� ����)
    {

    }
    
    void Update() // { } ������ �� ������ �����Ѵ�.
    {
        if(Input.GetKeyDown(KeyCode.A)) //���� AŰ�� �����ٸ�
                                        
        {
           transform.Translate(-tran_Var, 0, 0); //x������ -0.1f ��ŭ �̵��Ѵ�. y��, z�����δ� �̵����� �ʴ´�.
        }

        if (Input.GetKeyDown(KeyCode.D)) //���� DŰ�� �����ٸ�

        {
            transform.Translate(tran_Var, 0, 0); //x������ 0.1f ��ŭ �̵��Ѵ�. y��, z�����δ� �̵����� �ʴ´�.
        }

        if (Input.GetKeyDown(KeyCode.W)) //���� WŰ�� �����ٸ�
        {
            transform.Translate(0, 0, tran_Var); //z������ 0.1f ��ŭ �̵��Ѵ�. x��, y�����δ� �̵����� �ʴ´�.
        }

        if (Input.GetKeyDown(KeyCode.S)) //���� SŰ�� �����ٸ�
        {
            transform.Translate(0, 0, -tran_Var); //z������ -0.1f ��ŭ �̵��Ѵ�. x��, y�����δ� �̵����� �ʴ´�.
        }

    }
}
