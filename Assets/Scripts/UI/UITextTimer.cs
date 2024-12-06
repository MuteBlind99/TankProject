using TMPro;
using UnityEngine;

public class UITextTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    [SerializeField] private int timer=60 ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < timer; i++)
        {
            text.text = timer.ToString();
            
        }
        
    }
}
