using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    public AudioSource collisionSound; // ����� �ҽ��� �����ϱ� ���� ����

    void Start()
    {
        collisionSound = GetComponent<AudioSource>(); //�ν����� �信 �߰��� ����� �ҽ� ������Ʈ�� �ڵ�� ������ �����ϴ� �� �ʿ�
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        collisionSound.Play();//����� �ҽ��� ����� ���� ȿ�� ���� ���
        print("�浹�� �߻��߽��ϴ�.");
    }
}
