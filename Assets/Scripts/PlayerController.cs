using UnityEngine;
using UnityEngine.SceneManagement;

// 플레이어의 움직임과 총알 발사를 제어하는 컴포넌트
public class PlayerController : MonoBehaviour
{
    // 플레이어의 이동 속도 (Inspector에서 수정 가능)
    public float moveSpeed = 5f;

    // 발사할 총알의 프리팹 (Inspector에서 드래그 앤 드롭으로 설정해야 함)
    public GameObject bulletPrefab;

    // 자동 발사를 위한 시간 추적 변수
    public float startTime = 0f;

    public float maxHp;
    public float currentHp;

    // 게임 시작시 한 번 실행되는 함수
    void Start()
    {
        // 현재 시간을 저장하여 자동 발사 시간 계산의 기준점으로 사용
        startTime = Time.time;
        currentHp = maxHp;
    }

    // 총알을 생성하고 발사하는 함수
    void FireBullet()
    {
        // bulletPrefab을 현재 플레이어 위치에 생성 (회전 없음)
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }

    // 매 프레임마다 실행되는 함수
    void Update()
    {
        // 1초마다 자동으로 총알 발사
        if (Time.time - startTime > 0.35f)
        {
            startTime = Time.time;
            FireBullet();
        }

        // 스페이스바를 누르면 총알 발사
        if (Input.GetKey(KeyCode.Space))
        {
            FireBullet();
        }

        // 좌우상하 방향키로 플레이어 이동
        // 왼쪽 방향키: 왼쪽으로 이동
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1f, 0, 0) * Time.deltaTime * moveSpeed;
        }

        // 오른쪽 방향키: 오른쪽으로 이동
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1f, 0, 0) * Time.deltaTime * moveSpeed;
        }

        // 위쪽 방향키: 위로 이동
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 1f, 0) * Time.deltaTime * moveSpeed;
        }

        // 아래쪽 방향키: 아래로 이동
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -1f, 0) * Time.deltaTime * moveSpeed;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnemyBullet")
        {
            Destroy(collision.gameObject);

            currentHp--;
            if (currentHp <= 0)
            {
                SceneManager.LoadScene("GameOverScene");

            }
        }
    }
}
