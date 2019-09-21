using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyResourceController : ResourceController
{
    public int pointValue = 100;
    public override IEnumerator Death()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<ScoreScript>().IncreaseScore(pointValue);
        StartCoroutine(base.Death());
        return base.Death();
    }
}
