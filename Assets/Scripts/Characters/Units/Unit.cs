using UnityEngine;

public class Unit : MonoBehaviour
{
    [Header("Unit's settings")]
    [SerializeField] protected string unitName;
    [SerializeField] protected int manaCost = 10;
    [SerializeField] protected float moveSpeed = 3f;
    [SerializeField] protected int damageToEnemy = 50;

    protected bool isFighting = false;

    protected virtual void Start()
    {
        Debug.Log("The unit " + unitName + " has been summoned !");
    }

    public int GetManaCost()
    {
        return manaCost;
    }
}