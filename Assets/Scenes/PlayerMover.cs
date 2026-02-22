using UnityEngine;

#if ENABLE_INPUT_SYSTEM && !ENABLE_LEGACY_INPUT_MANAGER
using UnityEngine.InputSystem;
#endif

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool enableDebug = false;

    void Update()
    {
#if ENABLE_INPUT_SYSTEM && !ENABLE_LEGACY_INPUT_MANAGER
        // New Input System (no legacy input allowed)
        float h = 0f;
        float v = 0f;

        // Prefer gamepad left stick if present
        if (Gamepad.current != null)
        {
            Vector2 stick = Gamepad.current.leftStick.ReadValue();
            h = stick.x;
            v = stick.y;
        }
        else if (Keyboard.current != null)
        {
            // WASD / Arrow keys
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) h -= 1f;
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) h += 1f;
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) v += 1f;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) v -= 1f;
        }
#else
        // Legacy Input Manager
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
#endif

        Vector3 move = new Vector3(h, 0f, v) * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        if (enableDebug && (Mathf.Abs(h) > 0.01f || Mathf.Abs(v) > 0.01f))
        {
            Debug.Log("Player moving");
        }
    }
}