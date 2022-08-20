using UnityEngine;
using SimpleFPS;

[RequireComponent(typeof(AudioSource))]
public class Acceliration : MonoBehaviour
{
    [SerializeField] private int bonus;

    private AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed += bonus;
            fps.m_WalkSpeed += bonus;
            fps.m_RunSpeed += bonus;

            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed -= bonus;
            fps.m_WalkSpeed -= bonus;
            fps.m_RunSpeed -= bonus;
        }
    }
}
