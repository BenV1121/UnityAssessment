using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour, IDamageable
{
    public float healthValue = 200;
    public bool isDead = false;
    public Text Win;
    public bool textAvailability = false;

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
        Win.GetComponent<Text>().enabled = false;
        if (isDead)
        {
            Destroy(gameObject);
            Win.GetComponent<Text>().enabled = true;
        }
    }

    void Death()
    {
        isDead = true;
        textAvailability = true;
    }
}
