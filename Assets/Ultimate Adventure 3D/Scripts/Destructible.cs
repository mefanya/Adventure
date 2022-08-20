using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    [SerializeField] private int maxHitPoints;
    [SerializeField] private AudioClip soundTakeDamage;
    [SerializeField] private AudioClip soundKill;

    public UnityEvent Die;
    public UnityEvent ChangeHitPoints;
    private int hitPoints;

    private AudioSource audioSource;

    public void Start()
    {
        hitPoints = maxHitPoints;
        audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(int damage)
    {
        hitPoints -= damage;

        PlaySoundDamage();

        ChangeHitPoints.Invoke();

        if (hitPoints <= 0)
        {
            Kill();
        }
    }

    public void Healing(int addingHealth)
    {
        hitPoints += addingHealth;

        ChangeHitPoints.Invoke();

        if (hitPoints >= maxHitPoints)
        {
            hitPoints = maxHitPoints;
        }
    }

    public void Kill()
    {
        hitPoints = 0;

        Die.Invoke();
        ChangeHitPoints.Invoke();
    }

    public int GetHitPoints()
    {
        return hitPoints;
    }

    public int GetMaxHitPoints()
    {
        return maxHitPoints;
    }

    public void PlaySoundDamage()
    {
        audioSource.clip = soundTakeDamage;

        audioSource.Play();
    }

    public void PlaySoundKill()
    {
        audioSource.clip = soundKill;

        audioSource.Play();
    }
}