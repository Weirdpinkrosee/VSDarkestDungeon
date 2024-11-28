using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighwayManHealth : HPSystem
{
    void Start()
    {
        Subscribe();
        HP = 23;
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
