using UnityEngine;

public class DestructibleTank : MonoBehaviour
{

    [SerializeField] private int startHp = 100;

    private int _hp;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _hp = startHp;
    }

    // Update is called once per frame
    void Update()
    {
        
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
    
}
