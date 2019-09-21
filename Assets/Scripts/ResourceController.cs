using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResourceController : MonoBehaviour
{

    protected virtual void Awake()
    {
        currentHealth = maxHealth;
    }

    public int maxHealth = 2;
    public int currentHealth;

    public virtual void Damage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            StartCoroutine("Death");
        }

    }    


    public virtual IEnumerator Death()
    {
        Destroy(gameObject);
        yield return new WaitForSeconds(3);
    }
}
