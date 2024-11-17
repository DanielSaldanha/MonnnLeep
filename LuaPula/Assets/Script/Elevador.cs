using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float Speed = 100, Maxtime, time;
    [SerializeField] bool Aviso;
    void Start()
    {
       // LevelManager.suba += Subir;
        Aviso = false;
    }

   
    void Update()
    {
        if(PlayerMoving.main.autismo2 == true)
        {

            Subir();
        }
        if(Aviso == true)
        {
            time += Time.deltaTime;
            rb.AddForce(new Vector2(0, Speed));
        }
        if(time >= Maxtime)
        {
            time = 0;
            Aviso = false;
            Speed = 0;
        }
    }
    void Subir()
    {
        // rb.AddForce(new Vector2(0, Speed));
        Aviso = true;
    }
}
