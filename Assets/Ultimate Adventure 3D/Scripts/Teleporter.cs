using UnityEngine;
using SimpleFPS;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Teleporter target;
    [SerializeField] private GameObject impactEffect;

    [HideInInspector] public bool IsResieved;

    private void OnTriggerEnter(Collider other)
    {
        if (IsResieved) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            target.IsResieved = true;

            fps.transform.position = target.transform.position;

            Instantiate(impactEffect);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            IsResieved = false;
        }
    }
}
