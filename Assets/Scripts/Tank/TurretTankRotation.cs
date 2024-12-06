using UnityEngine.InputSystem;
using UnityEngine;


public class TurretRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // Vitesse de rotation en degrés par seconde

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            // ReSharper disable once Unity.InefficientMultiplicationOrder
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime, Space.Self);
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            // ReSharper disable once Unity.InefficientMultiplicationOrder
            transform.Rotate(Vector3.up* rotationSpeed * Time.deltaTime, Space.Self);
        }
    }

    // void RotateTurret(InputValue value)
    // {
    //     Rotate
    // }
}