using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // �ʵ��� �ν�����â ���� ����
    // public : �ܺ� Ŭ���� ���� ����, �ν�����â ������
    // private : �ܺ� Ŭ���� ���� �Ұ�, �ν�����â ���� ����
    // [HideInInspecter] public : �ܺ� Ŭ���� ���� ����, �ν�����â ���� ����
    // [SerializeField] private : �ܺ� Ŭ���� ���� �Ұ�, �ν�����â ������



    // this Ű����
    // ��ü �ڽ��� ��ȯ�ϴ� Ű����

    public int a = 3;
    private Transform tr;

    Vector3 move;
    

    private void Awake()
    {
        Debug.Log(this); // == Debug.Log(this.name);
        Debug.Log(this.gameObject); // this �� ��Ӱ� �Ǿ��ִ� -> ������ �����ϴ�. == Debug.Log(gameObject);
        Debug.Log(gameObject);

        // �ش� ���� ������Ʈ�� Ʈ������ ������Ʈ�� �����ü��ִ�.
        tr = this.gameObject.GetComponent<Transform>();
        // == gameObject.GetComponent<Transform>();
        // == GetComponent<Transform>();
        // == transform; --> �̰� ó�� �ӵ� �� ����; ����ص�!!!!!!!!!!!!!@#@#@#@#@#@#@#@#@#@@@@@@@@@@@@@@@####################

    }

    // Start is called before the first frame update
    void Start()
    {
        tr.position = Vector3.zero; // 0, 0, 0 �� ����. // �̰� ���� ���� ó�� �ӵ��� ������. #@#@@@@#######@#@#@#@#@#@@@
        transform.position = Vector3.zero; // ���� -> �� �ܰ躸�� �Ѵܰ� ����

        
        // GetComponent<Transform>().position = Vector3.zero;
        // gameObject.GetComponent<Transform>().position = Vector3.zero;
        // this.gameObject.GetComponent<Transform>().position = Vector3.zero; // ���� ����.
        // �� 3���� �� �Ⱦ� �ܰ谡 ���� tr ó�� �ʱ�ȭ�ϰ� ����ؾ���
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log($"h = {h}, v = {v}");
        move = new Vector3(h, 0, v);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // position ����ÿ���
        // position �� �����Ӵ� ��ȭ���� �����־�� �Ѵ�.
        // �ð� �� ��ġ ��ȭ��(�ӵ�) = ��ġ��ȭ�� / �ð�
        // ������ �ð� �� ��ġ ��ȭ��(�����Ӵ��� �ӵ�) = ��ġ��ȭ�� / �����ӽð�

        // ��ġ = ������ �ð� �� ��ġ ��ȭ�� * ������ �ð�
        // ����Ƽ������ ������ �ð��� �����Ѵ�.
        // tr.position += Vector3.right * Time.deltaTime;
        tr.position += move * Time.fixedDeltaTime;

    }
}
