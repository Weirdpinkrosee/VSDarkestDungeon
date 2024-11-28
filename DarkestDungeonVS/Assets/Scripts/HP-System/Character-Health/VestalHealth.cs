using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VestalHealth : HPSystem
{
    void Start()
    {
        Subscribe();
        HP = 24;
    }

    void Update()
    {
        if (HP <= 0)
        {
            Die();
        }
        Debug.Log(HP);
    }
}
