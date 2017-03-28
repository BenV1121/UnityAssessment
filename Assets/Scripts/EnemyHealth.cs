using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamageable
{
    public float healthValue = 100;
    public bool isDead = false;


    // Update is called once per frame
    public float EstimatedDamageTaken(float damageDealt)
    {
        return damageDealt;
    }

    public void TakeDamage(float damageDealth)
    {
        healthValue -= damageDealth;
        if (healthValue <= 0)
        {
            Death();
        }
    }

    public void Update()
    {
        if(isDead)
        {
            Destroy(gameObject);
        }
    }

    void Death()
    {
        isDead = true;
    }
}
