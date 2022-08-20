using UnityEngine;

public class DamageZone : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float damageRate;

    private Destructible thisDestructipleObject;
    private float timer;

    public void Update()
    {
        if (thisDestructipleObject == null) return;

        timer += Time.deltaTime;

        if (timer >= damageRate)
        {
            thisDestructipleObject.TakeDamage(damage);

            timer = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        thisDestructipleObject = other.GetComponent<Destructible>();
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Destructible>() == thisDestructipleObject) thisDestructipleObject = null;
    }
}
