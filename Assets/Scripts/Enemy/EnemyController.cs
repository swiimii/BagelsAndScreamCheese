using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int damageDealt = 1;

    private void FixedUpdate()
    {
        GetComponent<EnemyBehavior>().Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<ResourceController>())
            collision.gameObject.GetComponent<ResourceController>().Damage(damageDealt);
    }

}
