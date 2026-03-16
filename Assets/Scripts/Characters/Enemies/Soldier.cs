using UnityEngine;

public class Soldier : MonoBehaviour
{
    [Header("Enemy's Stats")]
    [SerializeField] private string enemyName = "Soldier";
    [SerializeField] private int health = 100;
    [SerializeField] private int damageToUnit = 150;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log($"{enemyName} got {health} HP.");

        if (health <= 0)
        {
            Die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Unit"))
        {
            HealthManager playerHealth = collision.transform.GetComponentInParent<HealthManager>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageToUnit);
            }
        }
    }


    private void Die()
    {
        Debug.Log($"{enemyName} has been destroyed !");
        Destroy(gameObject);
    }
}