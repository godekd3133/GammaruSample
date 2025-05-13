using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Start()
    {

    }

    void Update()
    {
        transform.position += new Vector3(0, -1f, 0) * Time.deltaTime * moveSpeed;
    }
}
