using UnityEngine;

public class Lizard : Unit
{
    public Animator animator;
    private GameObject currentTarget;

    void FixedUpdate()
    {
        if (isFighting && currentTarget == null)
        {
            isFighting = false;
            animator.SetFloat("Speed", 0f);
        }

        if (!isFighting)
        {
            transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);

            animator.SetFloat("Speed", MoveSpeed);
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