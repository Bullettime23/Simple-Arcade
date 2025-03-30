using UnityEngine;
using SimpleFPS;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Teleporter target;

    [HideInInspector] public bool IsResieved;

    private void OnTriggerEnter(Collider other)
    {
        if (IsResieved) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            target.IsResieved = true;

            fps.transform.position = target.transform.position;
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
