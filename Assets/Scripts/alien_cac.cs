using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien_cac : Enemy
{
    public int EnemyHealth = 20;
    public int EnemyDamage = 5;

    private GameObject playerGameObject;
    private Player player;
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        setHealth(EnemyHealth);
        setDamage(EnemyDamage);

        playerGameObject = GameObject.FindGameObjectWithTag("Player");
        player = playerGameObject.GetComponent<Player>();
        playerTransform = playerGameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (!player.isDead())
        {
            transform.LookAt(playerTransform);
        }
    }
}