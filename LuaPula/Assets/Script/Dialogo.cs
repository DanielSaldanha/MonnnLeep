using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public Sprite profile;
    public string speechTXT;
    public string actroName;

  //  public LayerMask playerLayer;
   // public float radious;

    ControleDialogo dc;
    void Start()
    {
        dc = FindObjectOfType<ControleDialogo>();
    }

   
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.tag == "Player")
        {
            Interacao();
        }
            
    }
    public void Interacao()
    {
        dc.Speech(profile, speechTXT, actroName);
    }
}
