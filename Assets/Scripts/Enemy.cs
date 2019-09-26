using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public int health = 20;
    public int damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        setHealth(health);
        setDamage(damage);
    }

    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */

    protected override void Die()
    {
        Destroy(gameObject);
    }
}
