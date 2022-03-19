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
        // Ű���� ȭ��ǥ ����, ������ ����Ű�� x �� ������
        float h = Input.GetAxis("Horizontal");

        // Ű���� ȭ��ǥ ����, �Ʒ��� ����Ű�� z �� ������
        float v = Input.GetAxis("Vertical");
        move = new Vector3(h, 0, v);
    }

    private void FixedUpdate()
    {
        tr.Translate(move * Speed * Time.fixedDeltaTime); 
    }

}
