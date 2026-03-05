using UnityEngine;

public class EnemiesDamaging : MonoBehaviour
{
    [SerializeField] private int damageAmount = 150;

    private void OnTriggerEnter2D(Collider2D other)
    {
        HealthManager playerHealth = other.gameObject.GetComponentInParent<HealthManager>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
            Debug.Log("Enemy has inflicted " + damageAmount + " damages to the unit !");
        }
    }
}