using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacoes : MonoBehaviour
{
    int naodeixo;
    int FUNCIONALOGODESGRACA;
    PlayerMoving main;
    Animator anim;
    void Start()
    {
        main = FindObjectOfType<PlayerMoving>();
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {

            FUNCIONALOGODESGRACA = 1;
        }     
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {

            FUNCIONALOGODESGRACA = 0;
        }       
       if (main.pulo == true && naodeixo == 1)
        {
            anim.SetInteger("mova", 2);
        }
        if (main.pulo == false && naodeixo == 1)
        {
            anim.SetInteger("mova", 1);

        }
        if (main.pulo == false && FUNCIONALOGODESGRACA == 1 && naodeixo == 1)//&& naodeixo == 1
        {
            anim.SetInteger("mova", 0);
        }
        
        if(main.tempo < main.MaxTimeFrame)
        {
            naodeixo = 0;
            anim.SetInteger("mova", 3);
        }
        else
        {
            naodeixo = 1;
        }
        
    }
}
