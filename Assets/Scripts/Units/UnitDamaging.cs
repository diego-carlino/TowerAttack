using UnityEngine;

public class UnitDamaging : MonoBehaviour
{
    [SerializeField] private int damageToEnemy = 50;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            HealthManager enemyHealth = other.GetComponentInParent<HealthManager>();

            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damageToEnemy);
                Debug.Log("The unit damaged the enemy !");
            }
        }
    }
}