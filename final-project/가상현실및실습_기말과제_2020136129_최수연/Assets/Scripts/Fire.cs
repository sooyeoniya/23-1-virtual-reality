using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
    public int maxBulletCount = 10;
    private int bulletCount;
    private int bulletPower = 1000;
    public Transform spawnBullet;
    public GameObject bullet;
    public Text bulletCountText;

    void Start()
    {
        bulletCount = maxBulletCount;
        UpdateBulletCountUI();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1) && bulletCount > 0)
        {
            //�Ѿ� ����
            GameObject bullet_Instance = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
            //������ �Ѿ��� Ridigbody ������Ʈ �ҷ���
            Rigidbody bullet_Rigidbody = bullet_Instance.GetComponent<Rigidbody>();
            //�������� ���� �ο�
            bullet_Rigidbody.AddForce(bullet_Rigidbody.transform.forward * bulletPower);

            bulletCount--;
            UpdateBulletCountUI();
        }
    }

    void UpdateBulletCountUI()
    {
        bulletCountText.text = "���� �Ѿ�: " + bulletCount.ToString();
    }

    public void IncreaseBulletCount()
    {
        bulletCount++;
        UpdateBulletCountUI();
    }
}