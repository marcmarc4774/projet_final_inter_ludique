
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [Header("Paramètres de rotation")]
    public float rotationSpeed = 180f;

    void Update()
    {
        transform.Rotate(
            Vector3.up * rotationSpeed * Time.deltaTime,
            Space.Self
        );
    }
}
