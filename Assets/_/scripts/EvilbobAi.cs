
using UnityEngine;

public class EvilbobAi : MonoBehaviour
{
    public Transform player;

    [Header("Movement")]
    public float detectionRange = 12f;
    public float speed = 3f;
    public float floatingHeight = 2f;

    [Header("Floating")]
    public float floatAmplitude = 0.3f;
    public float floatFrequency = 2f;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (player == null)
            return;

        float distance = Vector3.Distance(
            transform.position,
            player.position
        );

        if (distance <= detectionRange)
        {
            Vector3 targetPosition = new Vector3(
                player.position.x,
                player.position.y + floatingHeight,
                player.position.z
            );

            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                speed * Time.deltaTime
            );
        }

        // Flottement vertical permanent
        // Flottement vertical
        float floatOffset =
            Mathf.Sin(Time.time * floatFrequency) * floatAmplitude;

        Vector3 finalPosition = new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z
        );

        transform.position = Vector3.MoveTowards(
            transform.position,
            finalPosition,
            speed * Time.deltaTime
        );
    }
}
