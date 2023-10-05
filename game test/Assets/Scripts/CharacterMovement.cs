using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;


    public float xRange = 1;


    [SerializeField] private float _jumpForce = 200;
    [SerializeField] private Rigidbody _rb;


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
         var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
        vel.y = _rb.velocity.y;
        _rb.velocity = vel;


       if(Input.GetKeyDown(KeyCode.Space))
       {
            _rb.AddForce(Vector3.up * _jumpForce);
       }


    }


    // Delete any object with a tigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
            Destroy(other.gameObject);
    }
}

