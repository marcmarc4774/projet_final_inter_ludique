
using UnityEngine;
using StarterAssets;

public class JumpPad : MonoBehaviour
{
    [Header("Jump Pad Settings")]
    public float launchForce = 20f;

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController player =
            other.GetComponentInParent<FirstPersonController>();

        if (player != null)
        {
            player.LaunchPlayer(launchForce);
        }
    }
}
