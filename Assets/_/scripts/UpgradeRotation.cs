
using UnityEngine;

public class UpgradeRotation : MonoBehaviour
{
    [Header("Paramètres de rotation")]
    public float rotationSpeed = 180f;

    void Update()
    {
        transform.Rotate(
            Vector3.right * rotationSpeed * Time.deltaTime,
            Space.Self
        );
    }
}
