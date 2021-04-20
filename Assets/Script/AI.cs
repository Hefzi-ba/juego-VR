using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AI : MonoBehaviour
{
    public GameObject Target;
    public GameObject esqueleto;
    public float distanciadetector;
    public float distanciaatacar;
    public float tiempo;
    public Text puntaje;
    Rigidbody rb;
    public float fuerzasalto;

    void Update()
    {
        rb = GetComponent<Rigidbody>();
        float distancia = Vector3.Distance(Target.GetComponent<Transform>().position, esqueleto.GetComponent<Transform>().position);
        Debug.Log(distancia);
        if (distancia > distanciadetector)
        {
          
            Debug.Log("detenr");
            //detener
            esqueleto.GetComponent<Animator>().SetBool("caminar", false);

            esqueleto.GetComponent<NavMeshAgent>().isStopped = true;
            esqueleto.GetComponent<NavMeshAgent>().ResetPath();

        }
        else if (distancia > distanciaatacar && distancia < distanciadetector)
        {
            
            Debug.Log("caminar");
            esqueleto.GetComponent<NavMeshAgent>().SetDestination(Target.GetComponent<Transform>().position);
            esqueleto.GetComponent<Animator>().SetBool("caminar", true);
            //caminar

        }
        else if (distancia < distanciaatacar)
            
        {
            Debug.Log("atacar");
            if (tiempo < Time.time)
            {
                esqueleto.GetComponent<Animator>().SetTrigger("atacar");

                esqueleto.GetComponent<NavMeshAgent>().isStopped = true;
                esqueleto.GetComponent<NavMeshAgent>().ResetPath();
                tiempo = Time.time + .5f;
                float puntos = float.Parse(puntaje.text) - 10;
                puntaje.text = "" + puntos;
            }
        }

    }
    public void saltar() 
    {
        if (Input.GetKeyDown("jump")) rb.AddForce(
              new Vector3(0, fuerzasalto), ForceMode.Impulse
              );

    }

}


