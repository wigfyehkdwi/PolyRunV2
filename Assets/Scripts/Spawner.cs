using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] challengeObjects;
    public float spawnDelay = 1f;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating("InstantiateObjects", spawnDelay, spawnRate);
    }

    void InstantiateObjects()
    {
        GameObject challengeObject = challengeObjects[Random.Range(0, challengeObjects.Length)];
        Instantiate(challengeObject, transform.position, transform.rotation);
    }
}
