using UnityEngine;
using UnityEngine.InputSystem;

public class TankMovementsimple : MonoBehaviour
{
    [SerializeField] private float _linearSpeed = 5f;
    
    [SerializeField] private float _spinSpeed = 1f;
    
    [SerializeField] private float _linearForce = 5f;
   
    [SerializeField] private float _spinForce = 1f;

    private float _moveInput = 0f;
    
    private float _spinInput = 0f;
    
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
        _rigidbody.AddRelativeTorque(0,_spinInput * _spinForce, 0);
    }
    

    void OnSpinLeftRight(InputValue value)
    {
        _spinInput = value.Get<float>();
    }

    void OnMove(InputValue value)
    {
        _moveInput = value.Get<float>();
        
    }
}
