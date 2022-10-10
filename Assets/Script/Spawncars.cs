using UnityEngine;
using System.Collections;

public class Spawncars : MonoBehaviour
{
    [SerializeField]
    GameObject[] cars;
    private float[] values= { -1.78f, -0.61f, 0.57f, 1.68f }; 

    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while(true)
        {
            Instantiate(cars[Random.Range(0,cars.Length)],
                new Vector3(values[Random.Range(0,values.Length)],6f,0f),
                Quaternion.Euler(new Vector3(90,180,0))
                );
                yield return new WaitForSeconds(2.5f);
        }
    }
}
