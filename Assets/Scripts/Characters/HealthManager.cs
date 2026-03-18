using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private Slider HealthBar;
    [SerializeField] private TextMeshProUGUI HealthText;
    [SerializeField] private int MaxHealth = 100;
    private float CurrentHealth;

    void Start()
    {
        CurrentHealth = MaxHealth;
        UpdateUI();
    }

    public void TakeDamage(int amount)
{
        CurrentHealth -= amount;
    Debug.Log("Remaining health : " + CurrentHealth);

    CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);

    UpdateUI();

    if (CurrentHealth <= 0)
    {
        Die();
    }
}

    private void UpdateUI()
    {
        HealthBar.value = CurrentHealth;
        HealthText.text = "HP : " + CurrentHealth.ToString("0") + " / " + MaxHealth;
    }

    private void Die()
    {
        Debug.Log("The unit is dead !");
        Destroy(gameObject);
    }
}