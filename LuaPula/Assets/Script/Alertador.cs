using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alertador : MonoBehaviour
{
    public bool avisador;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.tag == "Player")
        {
            avisador = true;
        }
    }
    private void OnTriggerExit2D(Collider2D c)
    {
        if(c.tag == "Player")
        {
            avisador = false;
        }
    }
}
