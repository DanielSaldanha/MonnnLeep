using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public delegate void Mensagem();
    public static Mensagem mude2;
    Rigidbody2D rb;
    [SerializeField] float speed, jump;
    [SerializeField] int cu = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Andando();
        Pulo();
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
    private void OnTriggerEnter2D(Collider2D c)
    {
         if(c.tag == "Chao")
         {
            cu = 0;
         }  
    }
}
