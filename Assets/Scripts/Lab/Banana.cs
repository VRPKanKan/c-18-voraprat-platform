using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Banana : Weapon
{
    //เรียกจากคลาสแม่มา
    private void Start()
    {
        Damage = 30;
        Speed = 4;
        Move();
    }

    [SerializeField] float Speed;

    //ข้อความที่แสดงบน Console ของ Banana
    public override void Move()
    {
        Debug.Log("Banana moves with constant speed using Transform.");
    }

    public override void OnHitWith(Character character)
    {
        
    }
}
    

