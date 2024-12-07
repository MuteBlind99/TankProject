using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DestructibleTank : MonoBehaviour
{

    [SerializeField] private int startHp = 100;
    
    [SerializeField] private TextMeshProUGUI textMeshLife;
    
    [SerializeField] private GameObject tank;
    
    [SerializeField] private GameObject gameOver;

    private int _hp;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _hp = startHp;
    }

    // Update is called once per frame
    void Update()
    {
        textMeshLife.text = _hp.ToString();
    }

    public void TakeDamage(int damages)
    {
        _hp -= damages;
        if (_hp <= 0)
        {
            // Kaboom
            Destroy(gameObject, 1);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Proj"))
        {
            _hp--;
            if (_hp <= 0)
            {
                // Kaboom
                Destroy(tank, 0.5f);
                gameOver.SetActive(true);
            }
        }
    }
}
