using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{

    // Start is called before the first frame update
    void Start()
    {

    }

    protected override void Die()
    {
        Destroy(gameObject);
    }
}
