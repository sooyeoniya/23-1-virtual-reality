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
            //총알 생성
            GameObject bullet_Instance = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
            //생성된 총알의 Ridigbody 컴포넌트 불러옴
            Rigidbody bullet_Rigidbody = bullet_Instance.GetComponent<Rigidbody>();
            //물리적인 힘을 부여
            bullet_Rigidbody.AddForce(bullet_Rigidbody.transform.forward * bulletPower);

            bulletCount--;
            UpdateBulletCountUI();
        }
    }

    void UpdateBulletCountUI()
    {
        bulletCountText.text = "남은 총알: " + bulletCount.ToString();
    }

    public void IncreaseBulletCount()
    {
        bulletCount++;
        UpdateBulletCountUI();
    }
}