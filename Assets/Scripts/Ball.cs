using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 startForce;
    public Rigidbody rb;
        
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(startForce, ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
