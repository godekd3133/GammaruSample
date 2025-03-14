using UnityEngine;

public class ProjectileDirectonal : MonoBehaviour
{
    [SerializeField] private UnitMovement unitMovement;
    [SerializeField] private UnitWeaponHandler unitWeaponHandler;

    void Update()
    {
        if (unitMovement != null)
        {
            Vector3 moveDirection = new Vector3(0f, 0f, 0f);
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
                moveDirection.y = 1f;
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
                moveDirection.y = -1f;

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                moveDirection.x = -1f;
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                moveDirection.x = 1f;

            if (moveDirection.magnitude > 0f)
                unitMovement.Move(moveDirection.normalized);
        }
    }
}
