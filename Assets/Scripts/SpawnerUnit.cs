using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject unitPrefab;

    // Position d'apparition (0,0,0 par défaut)
    public Vector3 spawnPosition = Vector3.zero;

    public Transform spawnPoint;

    // endroit où sont stocker les clones invoqués de l'unité
    public Transform parentFolder;

    // Cette fonction doit être PUBLIC pour être vue par le bouton
    public void InvoquerUnite()
    {
        if (unitPrefab != null)
        {
            Instantiate(unitPrefab, spawnPoint.position, Quaternion.identity);
            Debug.Log("Unité invoquée !");
        }
    }
}