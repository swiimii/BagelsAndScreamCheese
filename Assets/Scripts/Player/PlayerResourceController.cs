using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResourceController : ResourceController
{
    public bool isInvincible = false;
    public bool isDead = false;
    public float invincibilityDuration = 2f;

    public override void Damage(int damage)
    {
        if (!isInvincible)
        {
            StartCoroutine("TemporaryInvincibility");
            base.Damage(damage);
        }
    }

    public IEnumerator TemporaryInvincibility()
    {
        isInvincible = true;
        float duration = 0;
        float frequency = .1f;
        
        while(duration < invincibilityDuration)
        {
            duration += Time.deltaTime;
            if ((int)(duration / frequency) % 2 != 0)
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, .5f);
            else
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            yield return null;
        }

        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);

        isInvincible = false;
    }

    public override IEnumerator Death()
    {
        isDead = true;
        // gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        MenuScript.ToggleMenu();
    }



}
