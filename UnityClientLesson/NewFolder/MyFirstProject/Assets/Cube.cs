using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // 필드의 인스펙터창 노출 설정
    // public : 외부 클래스 접근 가능, 인스펙터창 노출함
    // private : 외부 클래스 접근 불가, 인스펙터창 노출 안함
    // [HideInInspecter] public : 외부 클래스 접근 가능, 인스펙터창 노출 안함
    // [SerializeField] private : 외부 클래스 접근 불가, 인스펙터창 노출함



    // this 키워드
    // 객체 자신을 반환하는 키워드

    public int a = 3;
    private Transform tr;

    Vector3 move;
    

    private void Awake()
    {
        Debug.Log(this); // == Debug.Log(this.name);
        Debug.Log(this.gameObject); // this 가 어둡게 되어있다 -> 생략이 가능하다. == Debug.Log(gameObject);
        Debug.Log(gameObject);

        // 해당 게임 오브젝트의 트랜스폼 컴포넌트를 가져올수있다.
        tr = this.gameObject.GetComponent<Transform>();
        // == gameObject.GetComponent<Transform>();
        // == GetComponent<Transform>();
        // == transform; --> 이게 처리 속도 젤 빠름; 기억해둬!!!!!!!!!!!!!@#@#@#@#@#@#@#@#@#@@@@@@@@@@@@@@@####################

    }

    // Start is called before the first frame update
    void Start()
    {
        tr.position = Vector3.zero; // 0, 0, 0 이 들어간다. // 이게 가장 빠른 처리 속도를 가진다. #@#@@@@#######@#@#@#@#@#@@@
        transform.position = Vector3.zero; // 같다 -> 위 단계보다 한단계 많다

        
        // GetComponent<Transform>().position = Vector3.zero;
        // gameObject.GetComponent<Transform>().position = Vector3.zero;
        // this.gameObject.GetComponent<Transform>().position = Vector3.zero; // 전부 같다.
        // 위 3개는 잘 안씀 단계가 많아 tr 처럼 초기화하고 사용해야지
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
        // position 변경시에는
        // position 의 프레임당 변화량을 더해주어야 한다.
        // 시간 당 위치 변화량(속도) = 위치변화량 / 시간
        // 프레임 시간 당 위치 변화량(프레임단위 속도) = 위치변화량 / 프레임시간

        // 위치 = 프레임 시간 당 위치 변화량 * 프레임 시간
        // 유니티에서는 프레임 시간을 제공한다.
        // tr.position += Vector3.right * Time.deltaTime;
        tr.position += move * Time.fixedDeltaTime;

    }
}
