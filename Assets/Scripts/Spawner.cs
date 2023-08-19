using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject challengeObject;
    public float spawnDelay = 1f;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnRate);
    }

    void InstantiateObjects()
    {
        Instantiate(challengeObject, transform.position, transform.rotation);
    }
}
