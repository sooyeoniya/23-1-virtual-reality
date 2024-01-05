using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 10f;

    void Update() {

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 player = new Vector3(inputX * speed, 0, inputZ * speed);
        transform.GetComponent<Rigidbody>().velocity = player;
    }
}