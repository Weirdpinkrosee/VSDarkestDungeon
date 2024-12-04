using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighwayManHealth : HPSystem
{
    void Start()
    {
        Subscribe();
        hp = 23;
    }

    void Update()
    {
        if (hp <= 0)
        {
            Die();
        }
        Debug.Log(hp);
    }
}
