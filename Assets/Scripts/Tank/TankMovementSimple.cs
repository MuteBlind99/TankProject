using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovementsimple : MonoBehaviour
{
    [SerializeField] private float _linearSpeed = 5f;
    
    [SerializeField] private float _spinSpeed = 1f;
    
    [SerializeField] private float _linearForce = 5f;
   
    [SerializeField] private float _spinForce = 1f;
    
    [SerializeField] private float rotationSpeed = 50f;

    [SerializeField] private GameObject _turret;

    private float _moveInput = 0f;
    
    private float _spinInput = 0f;
    
    private float _spinTurretInput = 0f;
    
    private Rigidbody _rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_moveInput > 0f)
        {
            _rigidbody.AddForce(transform.forward * _linearForce);
        }
        else if (_moveInput < 0f)
        {
            _rigidbody.AddForce(transform.forward * -_linearForce);
        }

        if (_spinTurretInput > 0f)
        {
            _turret.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
        }
        else if (_spinTurretInput < 0f)
        {
            _turret.transform.Rotate(Vector3.down* rotationSpeed * Time.deltaTime, Space.Self);
        }
        // if (_spinInput>0f)
        // {
        //     // ReSharper disable once Unity.InefficientMultiplicationOrder
        //     transform.Rotate(Vector3.down * _spinSpeed * Time.deltaTime, Space.Self);
        // }
        // else if (_spinInput<0f)
        // {
        //     // ReSharper disable once Unity.InefficientMultiplicationOrder
        //     transform.Rotate(Vector3.up* _spinSpeed * Time.deltaTime, Space.Self);
        // }
        transform.Rotate(0f, _spinInput * _spinSpeed * Time.deltaTime, 0f);    
    }
    

    void OnSpinLeftRight(InputValue value)
    {
        _spinInput = value.Get<float>();
    }

    void OnMove(InputValue value)
    {
        _moveInput = value.Get<float>();
        
    }

    void OnSpinTurretLR(InputValue value)
    {
        _spinTurretInput = value.Get<float>();
    }
}
