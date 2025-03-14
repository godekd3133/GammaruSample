using UnityEngine;

public class UnitMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    public float MoveSpeed
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }
    public void Move(Vector3 directionNormal, float speedMultiplier = 1f)
    {
        transform.position += directionNormal * moveSpeed * speedMultiplier * Time.deltaTime;
    }
}
