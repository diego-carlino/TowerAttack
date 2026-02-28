using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy's Stats")]
    [SerializeField] private string enemyName = "Soldier";
    [SerializeField] private int health = 100;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log($"{enemyName} a maintenant {health} PV.");

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{enemyName} a été détruit !");
        Destroy(gameObject);
    }
}