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

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            Die();
        }
        Debug.Log(HP);
    }
}
