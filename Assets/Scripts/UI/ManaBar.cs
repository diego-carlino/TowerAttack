using UnityEngine;
using UnityEngine.UI;

public class ManaManager : MonoBehaviour
{
    [SerializeField] private Slider manaBar;
    [SerializeField] private int maxMana = 100;
    private float currentMana;

    void Start()
    {
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
    }
}