using UnityEngine;

namespace RollABall
{
    // ������ ��ũ��Ʈ.
    public class Item : MonoBehaviour
    {
        [SerializeField]
        private GameManager gameManager;

        private void Awake()
        {
            // GameManager ������Ʈ�� ���� ���� ������Ʈ�� �˻�.
            // FindFirst ���� �޼ҵ�� �˻��� �ϰ� ù��°�� ã������ �ű⼭ ����.
            gameManager = FindFirstObjectByType<GameManager>();
        }

        // �ı��� �� ����Ǵ� �޼ҵ�.
        private void OnDestroy()
        {
            gameManager.AddScore();
        }
    }
}