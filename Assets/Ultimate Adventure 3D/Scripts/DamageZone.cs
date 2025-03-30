using UnityEngine;

public class DamageZone : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float damageRate;

    private float timer;
    private Destructable destructable;

    private void Update()
    {
        if (destructable == null) return;

        timer += Time.deltaTime;

        if(timer >= damageRate)
        {
            destructable.ApplyDamage(damage);
            
            timer = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        destructable = other.GetComponent<Destructable>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Destructable>() != null)
        {
            destructable = null;
        }
    }
}
