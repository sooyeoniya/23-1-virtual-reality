using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEventModule : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //충돌한 오브젝트의 태그가 Monster일 경우
        if (other.gameObject.tag == "Monster")
        {
            //충돌한 오브젝트를 파괴(Monster)
            Destroy(other.gameObject);
            //자기 자신도 파괴(Bullet)
            Destroy(this.gameObject);
        }
    }
}