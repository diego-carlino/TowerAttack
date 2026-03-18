using UnityEngine;

public class Soldier : MonoBehaviour
{
    [Header("Enemy's Stats")]
    [SerializeField] private string EnemyName = "Soldier";
    [SerializeField] private int Health = 100;
    [SerializeField] private int DamageToUnit = 150;

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Debug.Log($"{EnemyName} got {Health} HP.");

        if (Health <= 0)
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
                playerHealth.TakeDamage(DamageToUnit);
            }
        }
    }


    private void Die()
    {
        Debug.Log($"{EnemyName} has been destroyed !");
        Destroy(gameObject);
    }
}