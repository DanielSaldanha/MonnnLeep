using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    //VARIAVEIS MULTI USO
    GameObject Clone, Clone2;
    [SerializeField] GameObject PCP;//Posi�ao Cabe�a Player
   public static PlayerMoving main;

    //ELEVADOR
    [SerializeField]public bool autismo, autismo2;
    [SerializeField] Transform BP;//botao pisi�ao
    [SerializeField] GameObject obj;


    //MENSAGENS
    public delegate void Mensagem();
    public static Mensagem mude2;//, inimigoAlert,inimigoPara;

    //MOVIMENTA�AO
    Rigidbody2D rb;
    [SerializeField] float speed, jump;
    [SerializeField] int cu = 0;

    //PORTA
    [SerializeField] int Chave = 0;
    public GameObject CloneChave;

   
    void Start()
    {
       
        main = this;
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
        rb.velocity = new Vector2(Mover * speed, rb.velocity.y);
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
          
            if (Input.GetKeyDown(KeyCode.E))
            {
                autismo2 = !autismo2;
                Destroy(Clone);
            }

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
        if (c.tag == "porta" && Chave == 1)
        {
            Destroy(c.gameObject);
            Chave -= 1;
            Destroy(Clone2);
        }
        if (c.tag == "chave")
        {
            Chave += 1;
            Destroy(c.gameObject);
            Clone2 = Instantiate(CloneChave, PCP.transform.position, Quaternion.identity);
            Clone2.transform.parent = PCP.transform;

        }
     
    }
    private void OnTriggerExit2D(Collider2D c)
    {
        if (c.tag == "Elevador")
        {
            Destroy(Clone);
        }
       
    }
}
