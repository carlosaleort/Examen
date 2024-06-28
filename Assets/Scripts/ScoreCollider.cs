using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollider : MonoBehaviour
{


    public ScoreManager scoreManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FallingObject"))
        {
            if (other.gameObject != null)
            {
                scoreManager.AddScore(1);
                Destroy(other.gameObject);

            }
        }
    }
}