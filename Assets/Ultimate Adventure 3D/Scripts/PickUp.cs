using SimpleFPS;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    protected virtual void OnTriggerEnter(Collider other)
    {
        FirstPersonController fpc = other.GetComponent<FirstPersonController>();

        if(fpc != null)
        {
            Destroy(gameObject);
        }
    }
}
