using UnityEngine;

public class Unit : MonoBehaviour
{
    [Header("Unit's settings")]
    [SerializeField] private string unitName;
    [SerializeField] private int health = 100;
    [SerializeField] private int manaCost = 10;
    [SerializeField] private float moveSpeed = 3f;

    void Start()
    {
        Debug.Log("The unit " + unitName + " has been summoned !");
    }

    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    public int GetManaCost()
    {
        return manaCost;
    }

}