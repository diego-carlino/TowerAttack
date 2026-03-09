using UnityEngine;

public class Frog : MonoBehaviour
{
    [Header("Unit's settings")]
    [SerializeField] private string unitName;
    [SerializeField] private int manaCost = 10;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private int damageToEnemy = 50;
    private bool isFighting = false;

    void Start()
    {
        Debug.Log("The unit " + unitName + " has been summoned !");
    }

    void FixedUpdate()
    {
        if (!isFighting)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isFighting = true;

            HealthManager enemyHealth = collision.transform.GetComponentInParent<HealthManager>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damageToEnemy);
            }
        }
    }


    public int GetManaCost()
    {
        return manaCost;
    }

}