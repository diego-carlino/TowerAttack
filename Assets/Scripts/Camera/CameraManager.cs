using UnityEngine;
using UnityEngine.InputSystem;

public class CameraManager : MonoBehaviour
{
    [Header("Mouvement")]
    public float MoveSpeed = 10f;
    public Vector3 StartPosition = new Vector3(0, 0, -10);

    [Header("Limites du Niveau")]
    public float MinX = -10f;
    public float MaxX = 10f;
    public float MinY = -5f;
    public float MaxY = 5f;

    void Start()
    {
        transform.position = StartPosition;
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

        Vector3 targetPosition = transform.position + move.normalized * MoveSpeed * Time.deltaTime;

        float clampedX = Mathf.Clamp(targetPosition.x, MinX, MaxX);
        float clampedY = Mathf.Clamp(targetPosition.y, MinY, MaxY);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}