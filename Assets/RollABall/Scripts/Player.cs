﻿using UnityEngine;

namespace RollABall
{
    public class Player : MonoBehaviour
    {
        // 이동속도 변수.
        [SerializeField]
        private float moveSpeed = 5f;

        // 트랜스폼 컴포넌트 참조 변수.
        [SerializeField]
        private Transform refTransform;

        // Start와 비슷한 시작할 때 한번 호출되는 메소드.
        private void Awake()
        {
            // 트랜스폼 참조 변수 초기화(설정).
            refTransform = transform;
        }

        void Update()
        {
            // 입력 받기.
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            // 이동 적용.
            // 입력 값 / 이동 속도 / 프레임 시간.
            // 이동 = 위치 + 벡터.

            // 이동 방향 만들기.
            Vector3 direction = new Vector3(horizontal, 0f, vertical);
            
            // 단위 벡터 만들기. (정규화).
            direction.Normalize();
            refTransform.position = refTransform.position
                + direction * moveSpeed * Time.deltaTime;
        }
    }
}