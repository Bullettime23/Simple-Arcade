using UnityEngine;
using UnityEngine.Events;

public class Destructable : MonoBehaviour
{
    [SerializeField] private int maxHitPoints;

    public UnityEvent Die;
    public UnityEvent ChangeHitpoints;
    private int hitPoints;

    private void Start()
    {
        hitPoints = maxHitPoints;
        ChangeHitpoints.Invoke();
    }
    public void ApplyDamage(int damage)
    {
        hitPoints -= damage;
        ChangeHitpoints.Invoke();

        if(hitPoints <= 0)
        {
            Kill();
        }
    }

    public void Kill()
    {
        hitPoints = 0;
        Die.Invoke();
    }

    public int GetHitpoints()
    {
        return hitPoints;
    }

    public int GetMaxHitpoints()
    {
        return maxHitPoints;
    }
}
