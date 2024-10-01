using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float speed = 10.0f;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
