using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float moveSpeed = 1f; // ������ �̵� �ӵ�
    private float startPosX; // ������ �ʱ� X ��ġ
    private float length = 15f; // ������ ���� ����

    private void Start()
    {
        startPosX = transform.position.x; // �ʱ� ��ġ ����
    }

    void Update()
    {
        // ������ �̵�
        float movement = moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.left * movement); // ���������� �̵��ϰ� ����

        // ������ �ݺ��ؼ� ��Ÿ������ ó��
        if (transform.position.x < startPosX - length) // �ε�ȣ ���� ����
        {
            transform.position = new Vector3(startPosX + length, transform.position.y, transform.position.z);
        }
    }
}
