using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_and_Color_Change : MonoBehaviour //Ŭ���� �̸��� �ۼ��Ѵ�. Ŭ���� �̸� �� ���� �̸��� ���� �ؾ� �Ѵ�.

    //�� ��ũ��Ʈ�� ������Ʈ�� �̵��� �ϸ� ��Ƽ���� ������ �ٲ�� ��ũ��Ʈ �̴�.
{
    Material material_Color; //��Ƽ���� ������ �ٲ� ����

    void Start() //��ũ��Ʈ���� �ѹ��� �����Ѵ�(1�����Ӹ� ����)
    {
        material_Color = gameObject.GetComponent<MeshRenderer>().material; //���ӿ�����Ʈ�� �Ž������� ������Ʈ �� ��Ƽ���� �Ӽ��� meterial_Color ������ ����
    }

    
    void Update() // { } ������ �� ������ �����Ѵ�.
    {
        if(Input.GetKeyDown(KeyCode.A)) //���� AŰ�� �����ٸ� 
        {
            transform.Translate(-0.1f, 0, 0); //x������ -0.1f ��ŭ �̵��Ѵ�. y��, z�����δ� �̵����� �ʴ´�.
            //material_Color.material.color = new Color (255 / 255f, 0 / 255f, 0 / 255f);
            //material_Color.material.color = Color.red;
            material_Color.color = new Color (1,0,0);
        }
        if (Input.GetKeyDown(KeyCode.D)) //���� DŰ�� �����ٸ�
        {
            transform.Translate(0.1f, 0, 0); //x������ 0.1f ��ŭ �̵��Ѵ�. y��, z�����δ� �̵����� �ʴ´�.
        }
        if (Input.GetKeyDown(KeyCode.W)) //���� WŰ�� �����ٸ�
        {
            transform.Translate(0, 0, 0.1f); //z������ 0.1f ��ŭ �̵��Ѵ�. x��, y�����δ� �̵����� �ʴ´�.
        }
        if (Input.GetKeyDown(KeyCode.S)) //���� SŰ�� �����ٸ�
        {
            transform.Translate(0, 0, -0.1f); //z������ -0.1f ��ŭ �̵��Ѵ�. x��, y�����δ� �̵����� �ʴ´�.
        }

    }
}
