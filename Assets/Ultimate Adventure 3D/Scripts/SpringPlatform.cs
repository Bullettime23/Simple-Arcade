using SimpleFPS;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpringPlatform : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5;
    private float jumpForceInitial;
    private new AudioSource audio;

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fpc = other.GetComponent<FirstPersonController>();

        if (fpc != null)
        {
            jumpForceInitial = fpc.m_JumpSpeed;
            fpc.m_JumpSpeed += jumpForce;
            fpc.m_Jump = true;

            audio.Play();
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
