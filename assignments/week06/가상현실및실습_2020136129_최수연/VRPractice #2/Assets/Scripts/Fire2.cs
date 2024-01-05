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
            //총알 생성
            GameObject bullet_Instance = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
            //생성된 총알의 Ridigbody 컴포넌트 불러옴
            Rigidbody bullet_Rigidbody = bullet_Instance.GetComponent<Rigidbody>();
            //물리적인 힘을 부여
            bullet_Rigidbody.AddForce(bullet_Rigidbody.transform.forward * bulletPower);
        }
    }
}