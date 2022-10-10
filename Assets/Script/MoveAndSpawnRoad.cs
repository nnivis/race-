using UnityEngine;
using UnityEditor;

public class MoveAndSpawnRoad : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.5f;
    [SerializeField]
    private GameObject road;
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < -8.0f)
        {
            Instantiate(road, new Vector3(-0.02f, 11.24f, 0.0f), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
