using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class danoesqueleto : MonoBehaviour
{

    private Animator animatorEsqueleto;
    private int contador = 0;

    void Start()
    {
        animatorEsqueleto = GetComponent<Animator>();
    }


    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.tag == "disparo")
        {
           
            Debug.Log("disparo" + contador);
            if (contador==3){
                animatorEsqueleto.SetTrigger("muerte");
                Destroy(gameObject, 10f);
            }
            else
            {
                animatorEsqueleto.SetTrigger("damage");
                contador++;

            }
            Debug.Log("mundo");

            

        }

    }




    
}
