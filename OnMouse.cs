using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouse : MonoBehaviour
{
   private void OnMouseEnter()
    {
        print("���콺 Ŀ���� ���Խ��ϴ�.");

    }
    
    private void OnMouseExit()
    {
        print("���콺 Ŀ���� �������ϴ�.");
    }

    private void OnMouseDown()
    {
        print("���콺 ��ư�� �����ϴ�.");
    }
    private void OnMouseUp()
    {
        print("���콺 ��ư�� �������ϴ�.");

    }
}
