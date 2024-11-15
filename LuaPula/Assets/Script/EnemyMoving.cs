using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    public GameObject Player;
    bool partida;
    void Start()
    {
       PlayerMoving.inimigoAlert += um;
       PlayerMoving.inimigoPara += dois;
    }

    
    void Update()
    {
        Mova();
        if (partida == true)
        {
            speed = 1;
        }
        if(partida == false)
        {
            speed = 0;
        }
    }
    void Mova()
    {
        Vector2 direcao = (Player.transform.position - transform.position).normalized;
        rb.velocity = direcao * speed;
    }
   public void um()
    {
        partida = true;
    }
    public void dois()
    {
        partida = false;
    }
}
