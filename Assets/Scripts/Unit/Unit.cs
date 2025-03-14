using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private float maxHp;
    [SerializeField] private float currentHp;

    [SerializeField] private UnitMovement unitMovement;
    [SerializeField] private UnitWeapon unitWeapon;

    public float MaxHp { get => maxHp; set => maxHp = value; }
    public float CurrentHp { get => currentHp; set => currentHp = value; }
    public UnitMovement UnitMovement { get => unitMovement; }
    public UnitWeapon UnitWeapon { get => unitWeapon; }


    void Start()
    {

    }

    void Update()
    {

    }
}
