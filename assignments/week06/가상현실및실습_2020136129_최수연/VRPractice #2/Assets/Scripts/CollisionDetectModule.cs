using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectModule : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //�浹�� ���� ������Ʈ�� ��ũ�� ���
        if(collision.gameObject.name == "��ũ")
        {
            //�浹�� ���� ������Ʈ�� ��ġ�� �������� �̵�
            collision.transform.position = Vector3.zero;
        }
    }
}
