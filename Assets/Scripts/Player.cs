using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Character
{
    public int PlayerHealth;
    public int PlayerDamage;

    // Start is called before the first frame update
    void Start()
    {
        setHealth(PlayerHealth);
        setDamage(PlayerDamage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Die()
    {
        Destroy(gameObject);
    }
}
