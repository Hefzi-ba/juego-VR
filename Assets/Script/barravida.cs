using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class barradevida : MonoBehaviour
{
    public float vida = 3;
    public Image barra;

    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 3);
        barra.fillAmount = vida / 3;
    }
}
