using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneda : MonoBehaviour
{

    public int contmoneda;
    private Text monedastxt;
    public Text Ganador;



    void Start()
    {
        monedastxt = GameObject.FindGameObjectWithTag("TXTMONEDA").GetComponent<Text>();
        Ganador.gameObject.SetActive(false);
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            monedastxt.text = (int.Parse(monedastxt.text) + 1).ToString();
            Destroy(gameObject);
            contmoneda++;
            if (contmoneda == 7)
            {
                Ganador.gameObject.SetActive(true);
            }
        }
        
      
    }
  
   
}
