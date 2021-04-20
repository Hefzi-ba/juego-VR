using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instancia;
    public Text Text;
    int score;
    void Start()
    {
        if (instancia == null)
            instancia = this;

    }
    public void cambioscore(int valormoneda)
    {
        score += valormoneda;
        Text.text = "X" + score.ToString();
    }
}
