using UnityEngine;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform endTarget;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endTarget.position, speed * Time.deltaTime);
    }
}
