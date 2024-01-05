using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControlModule : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //3차원 값을 저장하는 변수 position에
        //Transform 컴포넌트의 위치 값(position)을 저장
        Vector3 position = transform.position;
        //회전 값을 저장하는 변수 rotation에
        //Transform 컴포넌트의 회전 값(rotation)을 저장
        Quaternion rotation = transform.rotation;
        //3차원 값을 저장하는 변수 scale에
        //Transform 컴포넌트의 크기 값(localScale)을 저장
        Vector3 scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
