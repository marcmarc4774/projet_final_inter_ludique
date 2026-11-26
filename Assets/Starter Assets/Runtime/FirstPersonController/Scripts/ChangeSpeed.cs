
using UnityEngine;
using StarterAssets;

public class ChangeSpeed : MonoBehaviour
{
    public FirstPersonController player;

    [Header("Speed Settings")]
    public bool additive = false;

    public void ChangePlayerSpeed(float newSpeed)
    {
        if (additive)
        {
            player.ChangeSpeed(player.MoveSpeed + newSpeed);
        }
        else
        {
            player.ChangeSpeed(newSpeed);
        }
    }
}
