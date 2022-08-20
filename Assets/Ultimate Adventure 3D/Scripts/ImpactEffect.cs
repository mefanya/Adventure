using UnityEngine;

public class ImpactEffect : MonoBehaviour
{
    [SerializeField] private float lifeTime;

    public void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
