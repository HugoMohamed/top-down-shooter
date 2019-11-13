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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(playerDmg);
            Debug.Log(enemy.getHealth());
        }
        Destroy(gameObject);
    }
}
