using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform parentObjectTransform; 
    public Vector3 rotationAxis = Vector3.up; 
    public float rotationSpeed = 10f; 

    void Update()
    {
        transform.RotateAround(parentObjectTransform.position, rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
