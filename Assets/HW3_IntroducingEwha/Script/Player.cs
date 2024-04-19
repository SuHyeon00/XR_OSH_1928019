using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 4f; // 이동 속도
    public float rotationSpeed = 2f; // 회전 속도

    void Update()
    {   
        if(!DialogueScript.isDialogue) {
            Translate();
            Rotate();
        }
    }

    void Translate()
    {
        // 입력 처리
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        // 이동 벡터 계산
        Vector3 pos = moveSpeed * Time.deltaTime * new Vector3(inputH, 0f, inputV);

        transform.Translate(pos, Space.Self);
    }

    void Rotate()
    {
        // 마우스 입력
        float mouseX = Input.GetAxis("Mouse X");

        // 회전 처리
        transform.Rotate(mouseX * rotationSpeed * Vector3.up);
    }
}
