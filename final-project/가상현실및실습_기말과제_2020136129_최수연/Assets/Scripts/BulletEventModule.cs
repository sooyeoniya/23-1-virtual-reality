using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEventModule : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ������Ʈ�� �±װ� Monster�� ���
        if (other.gameObject.tag == "Monster")
        {
            //�浹�� ������Ʈ�� �ı�(Monster)
            Destroy(other.gameObject);
            //�ڱ� �ڽŵ� �ı�(Bullet)
            Destroy(this.gameObject);
        }
    }
}