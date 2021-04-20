using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject textDisplay;
    public int timepo = 30;
    public bool tiemporestante = false;
    public Text  GO;

    private void Start()
    {
        GO.gameObject.SetActive(false);
        textDisplay.GetComponent<Text>().text = "00:" + timepo;
        
        
    }
    private void Update()
    {
        if (tiemporestante == false && timepo > 0)
        {
            StartCoroutine(timertake());
            
            /*if( timepo == 0)
            {
                GO.gameObject.SetActive(true);
            }*/
        }
        
        
    }
    IEnumerator timertake()
    {
        tiemporestante = true;
        yield return new WaitForSeconds(1);
        timepo -=1;
        if (timepo<10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + timepo;
           
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "00:" + timepo;
            

        }
        tiemporestante = false;
        if (timepo <= 0)
        {
            GO.gameObject.SetActive(true);
        }
        
    }

    
}
