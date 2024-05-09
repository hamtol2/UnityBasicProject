using UnityEngine;

namespace RollABall
{
    public class GameManager : MonoBehaviour
    {
        // 점수.
        [SerializeField]
        private int score = 0;

        // 목표 점수.
        // 씬에 배치된 Item의 개수.
        [SerializeField]
        private int targetScore = 0;

        // 점수를 보여줄 TextUI.
        [SerializeField]
        private TMPro.TextMeshProUGUI scoreText;

        [SerializeField]
        private GameObject gameClearText;

        // 스크립트가 시작할 때 한번 실행(호출)되는 메소드.
        // Start / Awake -> 초기화.
        private void Awake()
        {
            // 검색 -> 아이템이 몇 개인지.
            // 게임오브젝트를 검색하는데 태그를 조건으로 할 수 있나?
            // 1. 일단 모든 게임오브젝트를 다 가져온다.
            // 2. 루프를 돌면서 하나씩 태그를 검사해서 확인한다.
            targetScore = GameObject.FindGameObjectsWithTag("Item").Length;
        }

        // 점수 획득 메소드.
        public void AddScore()
        {
            // 1점 획득 처리.
            score = score + 1;

            // 점수를 화면에 보여주기.
            scoreText.text = $"Score: {score}";

            // 게임 클리어 확인.
            if (IsGameClear() == true)
            {
                Debug.Log("Game Clear!");
                // 게임 오브젝트 켜기.
                gameClearText.SetActive(true);
            }
        }

        // 게임 클리어 확인.
        private bool IsGameClear()
        {
            // 예외처리 -> ?.
            // 게임 클리어 조건.
            return score == targetScore;
        }
    }
}