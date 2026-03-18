using UnityEngine;

public class Unit : MonoBehaviour
{
    [Header("Unit's settings")]
    [SerializeField] protected string UnitName;
    [SerializeField] protected int ManaCost = 10;
    [SerializeField] protected float MoveSpeed = 3f;
    [SerializeField] protected int DamageToEnemy = 50;

    protected bool isFighting = false;

    protected virtual void Start()
    {
        Debug.Log("The unit " + UnitName + " has been summoned !");
    }

    public int GetManaCost()
    {
        return ManaCost;
    }
}