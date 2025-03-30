using SimpleFPS;
using UnityEngine;

public class SpringPlatform : MonoBehaviour
{
    [SerializeField] float jumpForce = 5;
    private float jumpForceInitial;
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fpc = other.GetComponent<FirstPersonController>();

        if (fpc != null)
        {
            jumpForceInitial = fpc.m_JumpSpeed;
            fpc.m_JumpSpeed += jumpForce;
            fpc.m_Jump = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fpc = other.GetComponent<FirstPersonController>();

        if (fpc != null)
        {
            fpc.m_JumpSpeed = jumpForceInitial;
        }
    }
}
