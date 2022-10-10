using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private float speed =2.0f;
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed* Time.deltaTime);

        if(transform.position.y < -6)
            Destroy(gameObject);
    }
}
