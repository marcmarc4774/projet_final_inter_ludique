
using UnityEngine;

public class DestroyOnGoal : MonoBehaviour
{
    public GameObject objectToDestroy;

    public void DestroyTarget()
    {
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }
}
