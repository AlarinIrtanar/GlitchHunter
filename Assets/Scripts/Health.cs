using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int playerMaxHealth = 100;
    [SerializeField] int enemyMettaurHealth = 40;

    void OnTriggerEnter2D(Collider2D other)
    {
        Damage basicAttackDamage = other.GetComponent<Damage>();

        if(basicAttackDamage != null)
        {
            TakeDamage(basicAttackDamage.GetDamage());
            basicAttackDamage.Hit();
        }

    void TakeDamage(int basicAttackDamage)
    {
        enemyMettaurHealth -= basicAttackDamage;
        if (enemyMettaurHealth <=0)
        {
            Destroy(gameObject);
        }
    }        
    }
}
