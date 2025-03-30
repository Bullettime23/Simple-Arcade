using SimpleFPS;
using UnityEngine;

public class HealthPotion : PickUp
{
    [SerializeField] private GameObject impactEffect;
    [SerializeField] private int healing;
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        Destructable destructable = other.GetComponent<Destructable>();
        FirstPersonController fpc = other.GetComponent<FirstPersonController>();

        if (fpc != null && destructable != null)
        {
            destructable.ApplyHealing(healing);
            Instantiate(impactEffect);
        }

    }
}
