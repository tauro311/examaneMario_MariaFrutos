using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraundSensor: MonoBehaviour
{
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OntriggerEnter2D(Collider2D collider)
    {
        isGrounded = true;
    
    }

    void OntriggerExit2D(Collider2D collider)
    {
        isGrounded = false; 
    }
}
