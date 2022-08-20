using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing : Pikup
{
    [SerializeField] private GameObject impactEffect;
    [SerializeField] private int addingHealth;

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        Destructible destructible = other.GetComponent<Destructible>();

        destructible.Healing(addingHealth);

        Instantiate(impactEffect);
    }
}
