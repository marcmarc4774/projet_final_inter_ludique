
using UnityEngine;

public class ParticleOnGoal : MonoBehaviour
{
    public GameObject objectToDestroy;
    public ParticleSystem particlePrefab;

    public void PlayParticlesAndDestroy()
    {
        if (objectToDestroy == null || particlePrefab == null)
            return;

        // Récupère la position de l'objet
        Vector3 position = objectToDestroy.transform.position;
        Quaternion rotation = objectToDestroy.transform.rotation;

        // Crée et joue les particules à cette position
        ParticleSystem particles = Instantiate(
            particlePrefab,
            position,
            rotation
        );

        particles.Play();

        // Détruit l'objet
        Destroy(objectToDestroy);
    }
}
