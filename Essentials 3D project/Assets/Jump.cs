using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    [SerializeField] private float _jumpForce = 200;

    [SerializeField] private Rigidbody _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * _speed;
        vel.y = _rb.velocity.y;
        _rb.velocity = vel;

        if (Input.GetKeyDown(KeyCode.Space)) _rb.AddForce(Vector3.up * _jumpForce);
    }
}
