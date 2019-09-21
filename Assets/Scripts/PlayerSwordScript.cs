using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwordScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<ResourceController>().Damage();
    }
}
