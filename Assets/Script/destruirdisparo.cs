using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirdisparo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
        //f es para indicar que es float duracion de destruccion 5 seg
    }

    
}
