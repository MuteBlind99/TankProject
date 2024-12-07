using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TMPro;
using UnityEngine;

public class TurretNuberText : MonoBehaviour
{
    [SerializeField] private GameObject win;
    [SerializeField] private TextMeshProUGUI numbTurretText;

    [SerializeField] private List<Destructible> turret;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            var destructible = child.GetComponent<Destructible>();
            if (destructible!=null)
            {
                turret.Add(destructible);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        numbTurretText.text = turret.Count.ToString();
        foreach (var t in turret.ToList())
        {
            if (t._isDead)
            {
                turret.Remove(t);
            }
        }

        if (turret.Count <= 0)
        {
            win.SetActive(true);
        }
    }
}
