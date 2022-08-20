using UnityEngine;
using SimpleFPS;

[RequireComponent(typeof(AudioSource))]
public class Teleporter : MonoBehaviour
{
    [SerializeField] private Teleporter target;

    [HideInInspector] public bool IsReceive;

    private AudioSource audioSourse;

    public void Start()
    {
        audioSourse = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsReceive == true) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            target.IsReceive = true;

            fps.transform.position = target.transform.position;

            audioSourse.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            IsReceive = false;
        }
    }
}