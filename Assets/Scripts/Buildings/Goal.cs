using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public int GoalPoints = 5;
    public GameObject VictoryPanel;
    public TextMeshProUGUI PointsText;

    void Start()
    {
        if (VictoryPanel != null) VictoryPanel.SetActive(false);
        UpdateDisplay();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Unit"))
        {
            GoalPoints--;
            UpdateDisplay();

            Destroy(other.gameObject);

            if (GoalPoints <= 0)
            {
                WinGame();
            }
        }
    }

    void UpdateDisplay()
    {
        if (PointsText != null)
        {
            PointsText.text = "Congratulations ! You succeeded !";
        }
    }

    void WinGame()
    {
        if (VictoryPanel != null)
        {
            VictoryPanel.SetActive(true);
        }
    }
}