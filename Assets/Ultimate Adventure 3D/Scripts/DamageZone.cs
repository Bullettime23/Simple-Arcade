using UnityEngine;

public class DamageZone : MonoBehaviour
{
    [SerializeField] private int damage;
    private void OnTriggerEnter(Collider other)
    {
        Destructable destructable = other.GetComponent<Destructable>();

        if (destructable != null)
        {
            destructable.ApplyDamage(damage);
        }
    }
}
