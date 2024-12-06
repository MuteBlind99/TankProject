using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using Object = UnityEngine.Object;

public class TurretShooter : MonoBehaviour
{
    [SerializeField] private float fireRate = 0.5f;
    [SerializeField] private Projectile bullet;
    [SerializeField] private Transform firePoint;

    private Coroutine shoot_routine = null;
    //private bool _target = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Fire()
    {
        while (true)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            yield return new WaitForSeconds(fireRate);
        }
    }


    // void OnShoot(InputValue value)
    // {
    //     if (_target == true)
    //     {
    //         if (shoot_routine != null)
    //             StopCoroutine(shoot_routine);
    //
    //         shoot_routine = StartCoroutine("Fire");
    //     }
    //     else
    //     {
    //         StopCoroutine("Fire");
    //         shoot_routine = null;
    //     }
    // }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shoot_routine = StartCoroutine("Fire");
        }
        // _target = true;
        
       
    }

    private void OnTriggerExit(Collider other)
    {   
        if (other.CompareTag("Player"))  { 
            
            // _target = false;              
            StopCoroutine("Fire");           
            shoot_routine = null;
            
        }
       
       
       
    }
}