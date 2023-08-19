using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
