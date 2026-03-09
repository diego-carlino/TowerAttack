using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManaBar : MonoBehaviour
{
    [SerializeField] private Slider manaBar;
    [SerializeField] private TextMeshProUGUI manaText;
    [SerializeField] private int maxMana = 100;
    private float currentMana;

    void Start()
    {
        manaBar.maxValue = maxMana;
        currentMana = maxMana;
        UpdateUI();
    }

    public bool TrySpendMana(int amount)
    {
        if (currentMana >= amount)
        {
            currentMana -= amount;
            UpdateUI();
            return true;
        }

        Debug.Log("Not enough mana !");
        return false;
    }

    private void UpdateUI()
    {
        manaBar.value = currentMana;
        manaText.text = "Mana : " + currentMana.ToString("0") + " / " + maxMana.ToString();
    }
}