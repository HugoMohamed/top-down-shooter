using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien_range : Enemy
{
    private GameObject playerGameObject;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        playerGameObject = GameObject.FindGameObjectWithTag("Player");
        player = playerGameObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if(!player.isDead())
        {

        }
    }
}
