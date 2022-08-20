using SimpleFPS;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class Trigger : MonoBehaviour
{
    public UnityEvent Enter;
    public UnityEvent Exit;

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
            audioSource.Play();

            Enter.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            Exit.Invoke();
        }
    }
}