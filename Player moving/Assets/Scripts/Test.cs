using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody2D _rb;
    
    float _walkSpeed;
    float _inputHorizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb - gameObject.GetComponent<Rigibody2D>();

        _walkSpeed = 5.5f;
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = _inputHorizontal.GetAxisRaw("Horizontal");
        if (_inputHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_inputHorizontal * _walkSpeed, 0f));
        }
    }
}
