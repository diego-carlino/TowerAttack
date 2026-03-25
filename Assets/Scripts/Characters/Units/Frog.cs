using UnityEngine;

public class Frog : Unit
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