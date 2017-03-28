using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Describes a type that can take damage.
interface IDamageable
{
    // Estimates the amount of health lost if damage is dealt. 
    float EstimatedDamageTaken(float damageDealt);

    // Applies damage to this object.
    void TakeDamage(float damageDealt);
}

public class PlayerHealth : MonoBehaviour, IDamageable
{
    public float healthValue = 100;
    //public float armorValue = 20;

    Image Health;

    void Start()
    {
        Health = GameObject.FindGameObjectWithTag("hp").GetComponent<Image>();
    }

    public float EstimatedDamageTaken(float damageDealt)
    {
        return damageDealt;
    }

    public void TakeDamage(float damageDealth)
    {
        healthValue -= damageDealth;
        Health.fillAmount = healthValue / 100;
    }
}

