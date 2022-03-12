using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Transform tr;
    public float distance;
    public Vector3 dir = Vector3.forward;
    public float minSpeed;
    public float maxSpeed;
    public bool doMove;

    Vector3 move;

    private void Awake()
    {
        tr = GetComponent<Transform>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        if(doMove)
        {
            Move();
        }
    }
    private void Move()
    {
        float moveSpeed = Random.Range(minSpeed, maxSpeed);         // Unity���� �����ϴ� Random �Լ� (�츮�� ���� �ν��Ͻ�ȭ ��Ű���Ŵ� ���ҿ��� �����ϴ°�)
        move = dir * moveSpeed * Time.fixedDeltaTime;
        tr.Translate(move);
        distance += move.magnitude;                                 // �̰� ����..?

    }    
}
