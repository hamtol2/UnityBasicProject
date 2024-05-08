using UnityEngine;

namespace RollABall
{
    public class Player : MonoBehaviour
    {
        // �̵��ӵ� ����.
        [SerializeField]
        private float moveSpeed = 5f;

        // Ʈ������ ������Ʈ ���� ����.
        [SerializeField]
        private Transform refTransform;

        // Start�� ����� ������ �� �ѹ� ȣ��Ǵ� �޼ҵ�.
        private void Awake()
        {
            // Ʈ������ ���� ���� �ʱ�ȭ(����).
            refTransform = transform;
        }

        void Update()
        {
            // �Է� �ޱ�.
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            // �̵� ����.
            // �Է� �� / �̵� �ӵ� / ������ �ð�.
            // �̵� = ��ġ + ����.

            // �̵� ���� �����.
            Vector3 direction = new Vector3(horizontal, 0f, vertical);
            
            // ���� ���� �����. (����ȭ).
            direction.Normalize();
            refTransform.position = refTransform.position
                + direction * moveSpeed * Time.deltaTime;
        }
    }
}