using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private int maxHealth = 100;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();
    }

public void TakeDamage(int amount)
{
    Debug.Log($"Dégâts reçus : {amount}. Appelant : {gameObject.name}");





    currentHealth -= amount;
    Debug.Log("Remaining health : " + currentHealth);

    if (currentHealth < 0) currentHealth = 0;

    UpdateUI();

    if (currentHealth <= 0)
    {
        Die();
    }
}

    private void UpdateUI()
    {
        healthBar.value = currentHealth;
        healthText.text = "HP : " + currentHealth.ToString("0") + " / " + maxHealth;
    }

    private void Die()
    {
        Debug.Log("The unit is dead !");
        Destroy(gameObject);
    }
}