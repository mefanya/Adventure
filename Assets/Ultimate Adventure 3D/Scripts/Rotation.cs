using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Vector3 speed;

    public void Update()
    {
        targetTransform.Rotate(speed * Time.deltaTime);
    }
}
