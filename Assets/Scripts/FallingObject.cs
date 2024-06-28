using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public float fallSpeed = 3.0f;

    void Update()
    {
        transform.Translate(0, -fallSpeed * Time.deltaTime, 0);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject); // Destruye el objeto cuando sale de la pantalla
    }
}
