using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public delegate void Mensagem();
    public static Mensagem suba;


    void Start()
    {

    }


    void Update()
    {


    }
    public void Alerta()
    {
        if (suba != null)
        {
            suba();
        }
    }
}
    
