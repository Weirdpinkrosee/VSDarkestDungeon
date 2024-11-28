using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusaderHealth : HPSystem
{
    void Start()
    {
        Subscribe();
        HP = 33;
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
