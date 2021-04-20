using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo2 : MonoBehaviour
{
   
    public float velocidadisparo;
    private Rigidbody rb;
    public Transform explosion;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * velocidadisparo);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Instantiate(explosion, transform.position, transform.rotation);
       // Destroy(gameObject, 0f);
    }
    
}
