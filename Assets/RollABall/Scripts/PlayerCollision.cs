﻿using Unity.VisualScripting;
using UnityEngine;

// Home / end
// Ctrl + Shift
// Ctrl + 방향키.
namespace RollABall
{
    public class PlayerCollision : MonoBehaviour
    {
        // 점수를 관리하는 게임 관리자.
        [SerializeField]
        private GameManager gameManager;

        // 충돌에 비교할 태그 문자열 값.
        private string itemTag = "Item";

        // 충돌이 시작할 때 Unity가 실행해주는 메소드.
        private void OnTriggerEnter(Collider other)
        {
            // 충돌한 대상의 이름을 출력.
            // string ? 값 ? / 참조 ?
            // string -> char[]
            //Debug.Log($"OnTriggerEnter 충돌한 대상: {other.name}");

            // 부딪힌 물체가 아이템인지 확인.
            //if (other.name.Equals("Item") == true)
            //if (other.tag.Equals("Item") == true)
            if (other.CompareTag(itemTag) == true)
            {
                // other.gameObject는 other 컴포넌트가 속한 게임 오브젝트 값을 가져올 때 사용.
                Destroy(other.gameObject);

                // 게임 관리자에 점수 획득을 알림.
                //gameManager.AddScore();
            }
        }

        //// 충돌 중일 때 실행해주는 메소드.
        //private void OnTriggerStay(Collider other)
        //{
        //    Debug.Log($"OnTriggerStay 충돌한 대상: {other.name}");
        //}

        //// 충돌이 끝날 때 실행해주는 메소드.
        //private void OnTriggerExit(Collider other)
        //{
        //    Debug.Log($"OnTriggerExit 충돌한 대상: {other.name}");
        //}
    }
}