using UnityEngine;

public class Frog : Unit
{
    public Animator animator;

    void FixedUpdate()
    {
        if (!isFighting)
        {
            transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);

            animator.SetFloat("Speed", MoveSpeed);
        }
        else
        {
            animator.SetFloat("Speed", 0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Contact détecté avec : " + collision.gameObject.name + " (Tag: " + collision.gameObject.tag + ")");

        if (collision.gameObject.CompareTag("Enemy"))
        {
            isFighting = true;
            HealthManager enemyHealth = collision.transform.GetComponentInParent<HealthManager>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(DamageToEnemy);
            }
        }
    }
}