using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwordScript : MonoBehaviour
{

    public int damageDealt = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<ResourceController>().Damage(damageDealt);
    }
}
