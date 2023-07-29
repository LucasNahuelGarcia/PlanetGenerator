using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 rotationSpeed = Vector3.up;

    void FixedUpdate()
    {
        transform.Rotate(rotationSpeed);
    }
}