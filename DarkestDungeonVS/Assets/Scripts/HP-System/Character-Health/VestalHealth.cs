using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VestalHealth : HPSystem
{
    void Start()
    {
        Subscribe();
        hp = 24;
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
