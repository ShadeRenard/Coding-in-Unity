using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideObjects : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    [SerializeField] private Rigidbody _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        _rb.velocity = dir * _speed;
    }
}
