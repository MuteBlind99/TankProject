using UnityEditor.IMGUI.Controls;
using UnityEngine.InputSystem;
using UnityEngine;


public class TurretRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // Vitesse de rotation en degrés par seconde

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed|| Gamepad.current.leftShoulder.IsPressed())
        {
            // ReSharper disable once Unity.InefficientMultiplicationOrder
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime, Space.Self);
        }
        else if (Keyboard.current.rightArrowKey.isPressed || Gamepad.current.rightStick.IsPressed())
        {
            // ReSharper disable once Unity.InefficientMultiplicationOrder
            transform.Rotate(Vector3.up* rotationSpeed * Time.deltaTime, Space.Self);
        }
    }

    // void RotateTurret(InputValue value)
    // {
    //     Rotate
    // }
    void OnRotation(InputAction.CallbackContext context)
    {
        if (context.performed) transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime, Space.Self);
        
    }
}