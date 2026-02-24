using UnityEngine;

public class Unit : MonoBehaviour
{
    [Header("Paramètres de l'unité")]
    public string unitName;
    public int health = 100;
    public float moveSpeed = 3f;

    void Start()
    {
        Debug.Log("L'unité " + unitName + " a été invoquée !");
    }

    void Update()
    {
        // On pourra ajouter ici la logique de déplacement vers l'ennemi
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}