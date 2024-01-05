using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        //수평방향의 키보드 입력 시, -1 ~ 1
        float inputX = Input.GetAxis("Horizontal");
        //수직방향의 키보드 입력 시, -1 ~ 1
        float inputZ = Input.GetAxis("Vertical");

        Vector3 player = new Vector3(inputX * speed, 0, inputZ * speed);

        //velocity 변수(vector3) -> 속도를 지정 , 외부에 있는 Rigidbody 컴포넌트 가져옴
        this.transform.GetComponent<Rigidbody>().velocity = player;
    }
}