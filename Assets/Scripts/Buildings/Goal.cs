using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public int goalPoints = 5;
    public GameObject victoryPanel;
    public GameObject pointsTextObject;

    void Start()
    {
        if (victoryPanel != null) victoryPanel.SetActive(false);
        UpdateDisplay();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Unit"))
        {
            goalPoints--;
            UpdateDisplay();

            Destroy(other.gameObject);

            if (goalPoints <= 0 && victoryPanel != null)
            {
                victoryPanel.SetActive(true);
            }
        }
    }

    void UpdateDisplay()
    {
        if (pointsTextObject != null)
        {
            var t = pointsTextObject.GetComponent<TextMeshProUGUI>();
            if (t != null) t.text = "Goal : " + goalPoints;
        }
    }
}