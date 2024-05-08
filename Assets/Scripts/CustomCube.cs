using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Home / End.
// Shift + Home  / Shift + End
// Ctrl + 방향키(좌우).

public class CustomCube : MonoBehaviour
{
    // 필드. 변수(변하는 수-Variable).
    // public -> 외부 공개 + 인스펙터에 노출.
    // Attribute.
    [SerializeField]
    private Transform refTransform;

    // X축의 이동 속도.
    [SerializeField]
    private float xSpeed = 0.01f;

    // Start is called before the first frame update
    // 이벤트 함수(메소드) -> 엔진이 알아서 실행해준다.
    void Start()
    {
        // Console 창에 문자를 출력해주는 메소드.
        Debug.Log("Start");

        // 컴포넌트 검색하기.
        // 외우기.
        //refTransform = GetComponent<Transform>();
        refTransform = transform;

        // 이동.
        // 디버깅(1. 문제찾기 2. 문제해결).
        refTransform.Translate(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Console 창에 문자를 출력해주는 메소드.
        Debug.Log("Update");

        // 프레임 마다 조금씩 이동.
        refTransform.Translate(xSpeed, 0f, 0f);
    }
}