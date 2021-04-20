using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
   

    public  Text moneda;
    public Text Ganador;



    private void Start()
    {
        Ganador.gameObject.SetActive(false);
    }
    void Update()
    {
        
        float puntos = float.Parse(moneda.text);
        if (puntos == 7)
        {

            Ganador.gameObject.SetActive(true);
        }


       
      
    }
    
}
