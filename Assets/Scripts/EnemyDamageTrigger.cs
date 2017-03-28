using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageTrigger : MonoBehaviour
{
    public float damageOnContact = 5.0f;
    public float damageOverTime = 5.0f;

    private List<IDamageable> occupants = new List<IDamageable>();
    public bool shouldIgnoreEnemy = false;

    private void OnTriggerEnter(Collider other)
    {
        IDamageable target = other.gameObject.GetComponent<IDamageable>();

        if (target == null) { return; }
        if (shouldIgnoreEnemy)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                return; // abort, no need to do damage
            }
        }

        target.TakeDamage(damageOnContact);

        occupants.Add(target);
    }

    private void OnTriggerStat(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        IDamageable target = other.gameObject.GetComponent<IDamageable>();

        if (target == null) { return; }

        occupants.Remove(target);
    }
}
