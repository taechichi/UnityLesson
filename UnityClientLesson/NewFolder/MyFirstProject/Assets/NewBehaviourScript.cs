using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int a;
    [SerializeField] private int b; // -> ����Ƽ������ ���� ����

    // awake �Լ����� ó���� ���� �ʱ�ȭ�� �Ѵ�.
    private void Awake()
    {
        a = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        // �ٸ� ��� ������ �����ϱ� ���� �ʱ�ȭ�ȴ�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
