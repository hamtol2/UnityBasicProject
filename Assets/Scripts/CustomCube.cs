using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
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

    // 이동 속도.
    [SerializeField]
    private float moveSpeed = 0.01f;

    // 회전 속도(단위 초).
    [SerializeField]
    private float rotationSpeed = 360f;

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

        // 입력 처리 (방향키).
        // 좌우 방향키 입력 (A키/D키/왼쪽/오른쪽).
        float horizontal = Input.GetAxis("Horizontal");
        
        // 상하 방향키 입력 (W키/S키/위쪽/아래쪽).
        float vertical = Input.GetAxis("Vertical");

        // 입력은 방향 -> 오른쪽 입력 -> 오른쪽으로 이동.
        // 입력은 방향 -> 왼쪽 입력 -> 왼쪽으로 이동.

        //Debug.Log(horizontal);

        // 등속도 운동.
        // s = 속도(빠르기);
        // 프레임 마다 조금씩 이동.
        // Ctrl + K / Ctrl + C
        //refTransform.Translate(
        //    moveSpeed * horizontal * Time.deltaTime,
        //    moveSpeed * vertical * Time.deltaTime, 
        //    0f
        //);

        // 이동 Z축->물체 기준 앞뒤 이동.
        //refTransform.position = refTransform.position
        //    + new Vector3(0f, 0f, vertical * moveSpeed * Time.deltaTime);
        // 이동은 = 위치 + 벡터.
        refTransform.position = refTransform.position
            + refTransform.forward * vertical * moveSpeed * Time.deltaTime;

        // 회전.
        refTransform.rotation = refTransform.rotation
            * Quaternion.Euler(0f, horizontal * rotationSpeed * Time.deltaTime, 0f);

        // 회전 Y축.
        //refTransform.Rotate(
        //    new Vector3(
        //        0f,
        //        horizontal * rotationSpeed * Time.deltaTime,
        //        0f)
        //    );
    }
}