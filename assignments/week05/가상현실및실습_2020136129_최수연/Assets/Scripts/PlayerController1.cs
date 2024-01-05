using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        //��������� Ű���� �Է� ��, -1 ~ 1
        float inputX = Input.GetAxis("Horizontal");
        //���������� Ű���� �Է� ��, -1 ~ 1
        float inputZ = Input.GetAxis("Vertical");

        Vector3 player = new Vector3(inputX * speed, 0, inputZ * speed);

        //velocity ����(vector3) -> �ӵ��� ���� , �ܺο� �ִ� Rigidbody ������Ʈ ������
        this.transform.GetComponent<Rigidbody>().velocity = player;
    }
}