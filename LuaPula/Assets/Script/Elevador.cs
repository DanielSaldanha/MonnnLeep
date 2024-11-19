using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevador : MonoBehaviour
{
    public GameObject engrenagem, limitador, limitador2, posicional;
    public float z = 0;
    public float velocidadeRotacionatoria;
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
            Destroy(limitador);
        }
        if(Aviso == true)
        {
            time += Time.deltaTime;
            rb.AddForce(new Vector2(0, Speed));
            RotacaoEngrenagem();
        }
        if(time >= Maxtime)
        {
            Instantiate(limitador2, posicional.transform.position, Quaternion.identity);
            time = 0;
            Aviso = false;
            Speed = 0;
            velocidadeRotacionatoria = 0;
        }
       
    }
    void Subir()
    {
        // rb.AddForce(new Vector2(0, Speed));
        Aviso = true;
    }
    void RotacaoEngrenagem()
    {
     
        z = z + Time.deltaTime * velocidadeRotacionatoria;
        engrenagem.transform.rotation = Quaternion.Euler(0, 0, z);
    }
}
