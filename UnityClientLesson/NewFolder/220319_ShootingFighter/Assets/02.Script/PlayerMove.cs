using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Transform tr;
    Vector3 move;

    public float Speed = 1f;

    private void Awake()
    {
        tr = this.gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        // 키보드 화살표 왼쪽, 오른쪽 방향키로 x 축 움직임
        float h = Input.GetAxis("Horizontal");

        // 키보드 화살표 위쪽, 아랫쪽 방향키로 z 축 움직임
        float v = Input.GetAxis("Vertical");
        move = new Vector3(h, 0, v);
    }

    private void FixedUpdate()
    {
        tr.Translate(move * Speed * Time.fixedDeltaTime); 
    }

}
