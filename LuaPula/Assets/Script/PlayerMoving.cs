using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    //BOTAO ELEVADOR
    [SerializeField] bool autismo, autismo2;

    [SerializeField] Transform BP;//botao pisiçao
    GameObject Clone;
    [SerializeField] GameObject obj;

    public delegate void Mensagem();
    public static Mensagem mude2;
    Rigidbody2D rb;
    [SerializeField] float speed, jump;
    [SerializeField] int cu = 0;
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        autismo = false;
        autismo2 = false;
    }
    void Update()
    {
        Andando();
        Pulo();
        BotaoElevador();
    }
    void Andando()
    {
        float Mover = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Mover * speed * Time.deltaTime, rb.velocity.y);
    }
    void Pulo()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cu == 0)
        {
            if (mude2 != null)
            {
                mude2();
            }
            rb.AddForce(new Vector2(0, jump));
            cu = 1;
           
        }
    
    }
    void BotaoElevador()
    {

       
        if (autismo == true)
        {
           // autismo2 = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                autismo2 = !autismo2;
                Destroy(Clone);
            }

        }
        if (autismo2 == true)
        {
            LevelManager main;
            main = FindObjectOfType<LevelManager>();
            main.Alerta();
          //  Debug.Log("autismooooooo");
        }
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
         if(c.tag == "Chao")
         {
            cu = 0;
         }

        if (c.tag == "Elevador")
        {
            Clone = Instantiate(obj, BP.position, Quaternion.identity);
            autismo = true;                  
        }
    }
    //TOCAVEIS
    private void OnTriggerExit2D(Collider2D c)
    {
        if (c.tag == "Elevador")
        {
            Destroy(Clone);
        }
    }
}
