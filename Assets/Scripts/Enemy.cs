using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int maxHp;
    public int currentHp;

    public GameObject bulletPrefab;
    public float startTime = 0f;
    public float fireInterval = 1f;

    void Start()
    {
        currentHp = maxHp;
        startTime = Time.time;
    }

    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime * moveSpeed;

        if (Time.time - startTime > fireInterval)
        {
            startTime = Time.time;
            FireBullet();
        }
    }

    void FireBullet()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBullet")
        {
            Destroy(collision.gameObject);

            currentHp--;
            if (currentHp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
