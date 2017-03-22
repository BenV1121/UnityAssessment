using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public float damageOnContact = 5.0f;
    public float damageOverTime = 5.0f;

    private List<IDamageable> occupants = new List<IDamageable>();

    private void OnTriggerEnter(Collider other)
    {
        IDamageable target = other.gameObject.GetComponent<IDamageable>();

        if (target == null) { return; }

        target.TakeDamage(damageOnContact);

        occupants.Add(target);
    }

    private void OnTriggerStart(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        IDamageable target = other.gameObject.GetComponent<IDamageable>();

        if (target == null) { return; }

        occupants.Remove(target);
    }
}
