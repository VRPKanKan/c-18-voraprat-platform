using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    private void Start()
    {
        Damage = 40;
        Move();
    }

    private Rigidbody2D rb2d;
    private Vector2 force;

    public override void Move()
    {
        Debug.Log("Rock move by RigidBody:force");
    }

    public override void OnHitWith(Character character)
    {
        
    }
}
