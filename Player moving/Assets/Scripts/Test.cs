using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement; MonoBehavior
{
public float speed;
public float rotationSpeed;
public float jumpSpeed;

private CharacterController characterController;
private float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();

        ySpeed += Physics.gravity.y * Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            ySpeed = jumpSpeed;
        }

        characterController.SimpleMove(movementDirection * magnitude)

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.wp);

            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
// /
// / Rigidbody2D _rb;
    
    // float _walkSpeed;
    // float _inputHorizontal;
    
    // ACTUAL COMMENT Start is called before the first frame update
    // void Start()
    // {
        // _rb - gameObject.GetComponent<Rigibody2D>();

        // _walkSpeed = 5.5f;
    // }

    // ACTUAL COMMENT Update is called once per frame
    // void Update()
    // {
        // _inputHorizontal = _inputHorizontal.GetAxisRaw("Horizontal");
        // if (_inputHorizontal != 0)
        // {
            // _rb.AddForce(new Vector2(_inputHorizontal * _walkSpeed, 0f));
        // }
    // }
// }
