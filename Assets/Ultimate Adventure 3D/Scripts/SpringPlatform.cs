using UnityEngine;
using SimpleFPS;

[RequireComponent(typeof(AudioSource))]
public class SpringPlatform : MonoBehaviour
{
    [SerializeField] private int jumpForse;

    private AudioSource audioSourse;
    private float previusJumpForse;

    public void Start()
    {
        audioSourse = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            previusJumpForse = fps.m_JumpSpeed;

            fps.m_JumpSpeed += jumpForse;
            fps.m_Jump = true;

            audioSourse.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed = previusJumpForse;
        }
    }
}
