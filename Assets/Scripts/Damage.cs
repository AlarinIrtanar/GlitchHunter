using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] int basicAttackDamage = 1;
    [SerializeField] int cannonDamage = 40;
    [SerializeField] int swordDamage = 50;

    public int GetDamage()
    {
        return basicAttackDamage;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }
    // [SerializeField] int Damage = 1;
    // [SerializeField] int Damage = 1;
    // [SerializeField] int Damage = 1;
    // [SerializeField] int Damage = 1;
    // [SerializeField] int Damage = 1;
    // [SerializeField] int Damage = 1;
    // [SerializeField] int Damage = 1;
    // [SerializeField] int Damage = 1;
    // [SerializeField] int Damage = 1;
}
