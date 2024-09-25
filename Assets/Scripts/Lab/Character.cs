using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    protected Animator anim;
    protected Rigidbody2D rb;

    public bool IsDead()
    {
        return Health <= 0;
    }
    public void TakeDamge(int damage)
    {
        Health -= damage;
    }
}