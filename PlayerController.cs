using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    //public float leftBoundry = -10;
    //public float rightBoundary = 10;
    public float xRange = 25.0f;

    public GameObject projectilePrefab;


    private void Start()
    {
        
    }

    private void Update()
    {
        //if (transform.position.x < -10)
        //if (transform.position.x < leftBoundry)
        if (transform.position.x < -xRange)
        {
            //transform.position = new Vector3(-10 , transform.position.y, transform.position.z);
            //transform.position = new Vector3(leftBoundry , transform.position.y, transform.position.z);
            transform.position = new Vector3(-xRange , transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
