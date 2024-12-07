using UnityEngine;

public class Destructible : MonoBehaviour
{

    [SerializeField] private int startHp = 50;
    [SerializeField] private GameObject shooter;

    private int _hp;
    public bool _isDead = false;
    
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
            _isDead = true;
            Destroy(shooter, 0.2f);
        }
    }
    
}
