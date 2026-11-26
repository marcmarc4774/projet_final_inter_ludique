
using UnityEngine;
using StarterAssets;

public class ChangeSpeed : MonoBehaviour
{
    public FirstPersonController player;

    public void ChangePlayerSpeed(float newSpeed)
    {
        player.ChangeSpeed(newSpeed);
        player.ChangeSpeed(4f);
    }
}
