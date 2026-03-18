using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManaManager : MonoBehaviour
{
    public static ManaManager Instance;

    [SerializeField] private Slider ManaBar;
    [SerializeField] private TextMeshProUGUI ManaText;
    [SerializeField] private int MaxMana = 100;
    private float CurrentMana;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        ManaBar.maxValue = MaxMana;
        CurrentMana = MaxMana;
        UpdateUI();
    }

    public bool TrySpendMana(int amount)
    {
        if (CurrentMana >= amount)
        {
            CurrentMana -= amount;
            UpdateUI();
            return true;
        }
        Debug.Log("Not enough mana !");
        return false;
    }

    private void UpdateUI()
    {
        ManaBar.value = CurrentMana;
        ManaText.text = $"Mana : {CurrentMana:0} / {MaxMana}";
    }
}