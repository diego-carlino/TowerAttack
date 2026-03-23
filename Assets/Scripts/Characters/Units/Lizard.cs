using UnityEngine;

public class Lizard : Unit
{
    private GameObject currentTarget;

    void FixedUpdate()
    {
        if (isFighting && currentTarget == null)
        {
            isFighting = false;
        }

        if (!isFighting)
        {
            transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isFighting = true;
            currentTarget = collision.gameObject;

            HealthManager enemyHealth = collision.transform.GetComponentInParent<HealthManager>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(DamageToEnemy);
            }
        }
    }
}