using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    void Start()
    {
        // GameObject go = GameObject.Find("@Managers");//���ӿ�����Ʈ ��ü ���� �� @Managers�� ã�ƶ�-->���ϰ� ���� ����̱� ������ ���� ���x -->�̱��� ���(*��������, static)
        //Managers mg = go.GetComponent<Managers>();//managers��ũ��Ʈ�� ��ü ����.

        Managers mg = Managers.GetInstance();//Managers Ŭ�������� GetInstance()�� ����Ͽ�, ���������� ����� @Managers�� instance ���� �����´�
    
    
    }

    
    void Update()
    {
        
    }
}
