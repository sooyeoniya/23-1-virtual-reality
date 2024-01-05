using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float RotationSpeed = 200;
    public float speed = 50f;
    float xRotate = 0.0f;

    void Update()
    {
        //��������� Ű���� �Է� ��, -1 ~ 1
        float inputX = Input.GetAxis("Horizontal");
        //���������� Ű���� �Է� ��, -1 ~ 1
        float inputZ = Input.GetAxis("Vertical");

        Vector3 player = new Vector3(inputX * speed, 0, inputZ * speed);

        //velocity ����(vector3) -> �ӵ��� ���� , �ܺο� �ִ� Rigidbody ������Ʈ ������
        this.transform.GetComponent<Rigidbody>().velocity = player;

        KeyRotation1();
    }
    void KeyRotation()
    {
        float xInput = Input.GetAxis("Mouse X");
        float yInput = Input.GetAxis("Mouse Y");
        Vector3 rotationDirection = new Vector3(-yInput, xInput, 0);
        transform.eulerAngles += rotationDirection * Time.deltaTime * RotationSpeed;
    }
    void KeyRotation1()
    {
        float yRotation = Input.GetAxis("Mouse X") * 4f;
        float yRotate = transform.eulerAngles.y + yRotation;
        float xRotation = -Input.GetAxis("Mouse Y") * 4f;
        xRotate = Mathf.Clamp(xRotate + xRotation, -45, 80);

        transform.rotation = Quaternion.Euler(new Vector3(xRotate, yRotate, 0));
    }
}
