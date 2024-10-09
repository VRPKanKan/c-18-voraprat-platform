using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    
    [SerializeField] private int damage;
    // #owner: IShootable
    protected string owner = "IShootable";
    
    //Damage �����������¡㹤����١
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
    //OnHitWith
    public abstract void OnHitWith(Character character);
    //Move
    public abstract void Move();

    public int GetShootDirection()
    {
        return 1;
    }
}   

