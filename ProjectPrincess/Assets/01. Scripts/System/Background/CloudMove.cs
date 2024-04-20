using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float moveSpeed = 1f; // 구름의 이동 속도
    private float startPosX; // 구름의 초기 X 위치
    private float length = 15f; // 구름의 가로 길이

    private void Start()
    {
        startPosX = transform.position.x; // 초기 위치 저장
    }

    void Update()
    {
        // 구름을 이동
        float movement = moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.left * movement); // 오른쪽으로 이동하게 수정

        // 구름이 반복해서 나타나도록 처리
        if (transform.position.x < startPosX - length) // 부등호 방향 수정
        {
            transform.position = new Vector3(startPosX + length, transform.position.y, transform.position.z);
        }
    }
}
