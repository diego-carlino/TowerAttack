using UnityEngine;
using UnityEngine.InputSystem;

public class CameraFollow : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        Keyboard kb = Keyboard.current;
        if (kb == null) return;

        Vector3 move = Vector3.zero;

        if (kb.upArrowKey.isPressed) move.y += 1;
        if (kb.downArrowKey.isPressed) move.y -= 1;
        if (kb.leftArrowKey.isPressed) move.x -= 1;
        if (kb.rightArrowKey.isPressed) move.x += 1;

        transform.position += move.normalized * speed * Time.deltaTime;

        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject != null) return;
    }
}