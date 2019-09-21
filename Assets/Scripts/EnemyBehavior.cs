using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = .05f;

    protected virtual void Start()
    {
        if (!player)
            player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Called from FixedUpdate - no time.deltatime needed
    public void Move()
    {
        if(player.gameObject.activeInHierarchy)
            transform.Translate((player.position - transform.position).normalized * moveSpeed);
    }
}
