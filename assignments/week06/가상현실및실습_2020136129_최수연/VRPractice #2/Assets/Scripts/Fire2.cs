using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire2 : MonoBehaviour
{
    private int bulletPower = 1000;
    public Transform spawnBullet;
    public GameObject bullet;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�Ѿ� ����
            GameObject bullet_Instance = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
            //������ �Ѿ��� Ridigbody ������Ʈ �ҷ���
            Rigidbody bullet_Rigidbody = bullet_Instance.GetComponent<Rigidbody>();
            //�������� ���� �ο�
            bullet_Rigidbody.AddForce(bullet_Rigidbody.transform.forward * bulletPower);
        }
    }
}