using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroOutBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10;

    void Start()
    {
        
    }

    void Update()
    {
        //if an object goes past the player viev in the game, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
    }
}
