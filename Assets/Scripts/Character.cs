using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private int health;
    private int damage;

    protected virtual void TakeDamage(int dmg)
    {
        if(health - dmg <= 0)
        {
            health = 0;
            Die();
        }
    }

    public int getHealth()
    {
        return health;
    }
    
    public int getDamage()
    {
        return damage;
    }

    public void setHealth(int health)
    {
        this.health = health;
    }

    public void setDamage(int damage)
    {
        this.damage = damage;
    }

    protected abstract void Die();
}
