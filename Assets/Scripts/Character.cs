using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private int health;
    private int damage;
    private bool dead = true;

    public virtual void TakeDamage(int dmg)
    {
        if(health - dmg <= 0)
        {
            health = 0;
            dead = true;
            Die();
        }
        else
            health -= dmg;
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

    public bool isDead()
    {
        return dead;
    }

    protected abstract void Die();
}
