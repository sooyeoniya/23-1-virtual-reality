using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControlModule : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //3���� ���� �����ϴ� ���� position��
        //Transform ������Ʈ�� ��ġ ��(position)�� ����
        Vector3 position = transform.position;
        //ȸ�� ���� �����ϴ� ���� rotation��
        //Transform ������Ʈ�� ȸ�� ��(rotation)�� ����
        Quaternion rotation = transform.rotation;
        //3���� ���� �����ϴ� ���� scale��
        //Transform ������Ʈ�� ũ�� ��(localScale)�� ����
        Vector3 scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
