using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 50f;
    private GameObject player;
    private int playerDmg;
    
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerDmg = player.GetComponent<Player>().getDamage();
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = transform.up * speed;
        // The bullet disappear after time if nothing has been touched
        Destroy(gameObject, 2.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if an enemy is touched, inflict damage
        Enemy enemy = collision.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(playerDmg);
        }
        Destroy(gameObject);
    }
}
