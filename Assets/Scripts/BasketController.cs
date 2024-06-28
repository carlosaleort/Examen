using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public float speed = 10.0f;
    public ScoreManager scoreManager; // Referencia al ScoreManager

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(move, 0, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FallingObject"))
        {
            scoreManager.AddScore(1); // Aumenta el puntaje
            Destroy(other.gameObject); // Destruye el objeto caído
        }
    }
}
