using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int a;
    [SerializeField] private int b; // -> 유니티에서만 조정 가능

    // awake 함수에서 처음의 변수 초기화를 한다.
    private void Awake()
    {
        a = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        // 다른 멤버 변수에 접근하기 전에 초기화된다.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
