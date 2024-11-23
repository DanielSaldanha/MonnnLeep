using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public Sprite profile;
    public string[] speechTXT;
    public string actroName;
    bool permissao,permissao2;

  //  public LayerMask playerLayer;
   // public float radious;

    ControleDialogo dc;
    void Start()
    {
        dc = FindObjectOfType<ControleDialogo>();
    }

   
    void Update()
    {
        if(permissao == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interacao();
                permissao = false;
            }
        }
     
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.tag == "Player")
        {
            permissao = true;
           // Interacao();
        }
            
    }
    
    private void OnTriggerExit2D(Collider2D c)
    {
        if (c.tag == "Player")
        {
            if(permissao == true) permissao = false;

        }

    }
    
    public void Interacao()
    {
        dc.Speech(profile, speechTXT, actroName);
    }
}
