using UnityEngine;

public class EnemiesDamaging : MonoBehaviour
{
    [SerializeField] private int damageToUnit = 150;

    private void OnTriggerEnter2D(Collider2D other)
    {
        HealthManager playerHealth = other.gameObject.GetComponentInParent<HealthManager>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageToUnit);
            Debug.Log("Enemy has inflicted " + damageToUnit + " damages to the unit !");
        }
    }
}