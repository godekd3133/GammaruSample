using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float moveSpeed = 20f;

    void Update()
    {
        transform.position += new Vector3(0, 1f, 0) * Time.deltaTime * moveSpeed;
    }
}
