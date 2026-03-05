using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject unitPrefab;

    [SerializeField] private Vector3 spawnPosition = Vector3.zero;

    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform parentFolder;

    [SerializeField] private ManaManager manaManager;

    public void InvoquerUnite()
    {
        if (unitPrefab == null || manaManager == null)
        {
            Debug.LogError("Missing prefab or manaManager");
            return;
        }

        int cost = unitPrefab.GetComponent<Unit>().GetManaCost();

        if (manaManager.TrySpendMana(cost))
        {
            Instantiate(unitPrefab, spawnPoint.position, Quaternion.identity, parentFolder);
        }
    }
}