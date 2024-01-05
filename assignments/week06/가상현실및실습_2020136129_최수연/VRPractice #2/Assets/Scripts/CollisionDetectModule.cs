using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectModule : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //충돌한 게임 오브젝트가 탱크일 경우
        if(collision.gameObject.name == "탱크")
        {
            //충돌한 게임 오브젝트의 위치를 원점으로 이동
            collision.transform.position = Vector3.zero;
        }
    }
}
