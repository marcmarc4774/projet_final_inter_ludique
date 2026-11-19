
using UnityEngine;

public class SawRotation : MonoBehaviour
{
    [Header("Paramètres de rotation")]
    public float rotationSpeed = 180f;

    void Update()
    {
        transform.Rotate(
            Vector3.forward * rotationSpeed * Time.deltaTime,
            Space.Self
        );
    }
}
