using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    float speed = 20F;
    
    void Start()
    {

    }

    void Update()
    {
        float position = Input.GetAxis("Vertical");
        position= position * speed*Time.deltaTime;
        //input = �Է���ġ �Է��� ���� �� ���� ,GetAxis = �Է� ���� ������ --> getaxis("vertical) = ���ι����� ��, �Ʒ� ����Ű(0 ������ ���� �� / 1 �� / -1 �Ʒ�)      
        //� ����Ű�� ������ ���� ���� position���� ������� �������� ���� ,>position(�����̴� ����), speed(�����̴� �ӵ�) , Time.deltaTime(������ ���� �ð�)
        transform.Translate(Vector3.forward * position);
        //Translate �޼��� = ������Ʈ�� ��ġ ���� , Vector3 = 3���� ������Ʈ�� ��ǥ���� ���� Ŭ���� , forward = z������ 1��ŭ �̵��϶�� �ǹ�.
        //-->position���� ���ϹǷ�, ����Ű�� �ȴ�����(position = 0) �������� �ʴٰ�, � ��ư�� ���������� ���� z���� ������ ��, ���� �������� ������.
      

    }
}
