using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupBehaviour : MonoBehaviour
{

    private Collider2D ballColider;

    void Awake() 
    {
        ballColider = GetComponent<Collider2D>();
    }

    void Update() {
    }

    
}
