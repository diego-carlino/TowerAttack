using UnityEngine;
using UnityEngine.InputSystem;

public class CameraManager : MonoBehaviour
{
    [Header("Mouvement")]
    public float moveSpeed = 10f;
    public Vector3 startPosition = new Vector3(0, 0, -10);

    void Start()
    {
        transform.position = startPosition;
        transform.rotation = Quaternion.identity;
    }

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        Keyboard kb = Keyboard.current;
        if (kb == null) return;

        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject != null) return;

        Vector3 move = Vector3.zero;

        if (kb.upArrowKey.isPressed) move.y += 1;
        if (kb.downArrowKey.isPressed) move.y -= 1;
        if (kb.leftArrowKey.isPressed) move.x -= 1;
        if (kb.rightArrowKey.isPressed) move.x += 1;

        transform.position += move.normalized * moveSpeed * Time.deltaTime;
    }
}