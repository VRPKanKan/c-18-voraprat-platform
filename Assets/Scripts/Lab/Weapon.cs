using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    
    [SerializeField] private int damage;
    protected string owner;

    // Property ����Ѻ Damage
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    
    public abstract void OnHitWith(Character character);

    public abstract void Move();

    public int GetShootDirection()
    {
        return 1;
    }
}   

