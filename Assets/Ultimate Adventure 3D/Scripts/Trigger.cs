using SimpleFPS;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent Enter;
    public UnityEvent Exit;
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fpc = other.GetComponent<FirstPersonController>();

        if (fpc != null)
        {
            Enter.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fpc = other.GetComponent<FirstPersonController>();

        if (fpc != null)
        {
            Exit.Invoke();
        }
    }
}
