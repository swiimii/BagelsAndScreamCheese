using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ResourceController : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public abstract void Damage();
}
