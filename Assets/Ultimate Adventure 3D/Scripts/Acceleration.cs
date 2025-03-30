using SimpleFPS;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    [SerializeField] float bonus = 5;
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fpc = other.GetComponent<FirstPersonController>();

        if (fpc != null)
        {
            fpc.m_WalkSpeed += bonus;
            fpc.m_RunSpeed += bonus;
            fpc.m_JumpSpeed += bonus;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fpc = other.GetComponent<FirstPersonController>();

        if (fpc != null)
        {
            fpc.m_WalkSpeed -= bonus;
            fpc.m_RunSpeed -= bonus;
            fpc.m_JumpSpeed -= bonus;
        }
    }
}
