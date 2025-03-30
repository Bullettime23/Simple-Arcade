using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destructable destructable = other.GetComponent<Destructable>();

        if (destructable != null)
        {
            destructable.Kill();
        }
    }
}
