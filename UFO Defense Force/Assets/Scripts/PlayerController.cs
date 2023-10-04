using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;
    public GameObject lazer;


    // Update is called once per frame
    void Update()
    {
        // Set HorizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keeps player within bounds
        // Left Side Wall
        if(transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
        // Right Side Wall
        if(transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
        // if space bar is pressed fire
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Creates laser at the blaster transform position maintaining the objects rotation
            Instantiate(lazer, blaster.transform.position, lazer.transform.rotation);
        }

    }

    // Delete any object with a tigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
            Destroy(other.gameObject);
    }
}
