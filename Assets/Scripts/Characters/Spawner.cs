using UnityEngine;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject UnitPrefab;
    [SerializeField] private Vector3 SpawnPosition = Vector3.zero;
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private Transform ParentFolder;
    [SerializeField] private ManaManager ManagerMana;

    public void InvokeUnit()
    {
        if (UnitPrefab == null || ManagerMana == null)
        {
            Debug.LogError("Missing prefab or manaManager");
            return;
        }

        int cost = UnitPrefab.GetComponent<Unit>().GetManaCost();

        if (ManagerMana.TrySpendMana(cost))
        {
            Instantiate(UnitPrefab, SpawnPoint.position, Quaternion.identity, ParentFolder);

            if (EventSystem.current != null)
            {
                EventSystem.current.SetSelectedGameObject(null);
            }
        }
    }
}