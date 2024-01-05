using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEventModule : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
    {
        //�浹�� ������Ʈ�� �±װ� Target�� ���
        if(other.gameObject.tag == "Target")
        {
            //�浹�� ������Ʈ�� �ı�
            Destroy(other.gameObject);
            //�ڱ� �ڽŵ� �ı�
            Destroy(this.gameObject);
        }
    }
}
