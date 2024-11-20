using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    
    //TIRO
    [SerializeField] Tiro prefabTiro;
    Camera camera;

    //VIDA
   public GameObject[] vida;
   public int vidaAtual = 4;
    
    void Start()
    {
        camera = Camera.main; // essa variavel tem o valor de MainCamera
    }
    void Update()
    {
        Clicado();
       if(vidaAtual == 0)
        {
            Destroy(gameObject);
        }


    }
    //ELEVADOR
    private void OnTriggerEnter2D(Collider2D c)
    {
        
       
    }
    void Clicado()
    {
        if (Input.GetMouseButtonDown(0)) // 0 = esquerda e 1 = direita
        {
            Vector2 posicaoMouse = Input.mousePosition;
            Vector3 PosiçaoDoMouseNoMundo = camera.ScreenToWorldPoint(posicaoMouse);//ScreenToWorldPoint > converte a posiçao de pixel para o mundo 2d
            PosiçaoDoMouseNoMundo.z = 0;                                            //no geral isso e muito necessario

            Vector3 direcao = (PosiçaoDoMouseNoMundo - transform.position).normalized;//quanto mais perto do personagem vc clica mais lento o tiro fica
                                                                                      //o normalized arruma isso fazendo a velocidade ficar constante
            Tiro novoTiro = Instantiate(prefabTiro, transform.position, Quaternion.identity);
            novoTiro.Mova(direcao);
        }
    }
   public void VidaPerdida()
    {
        if (PlayerMoving.main.vidao == true)
        {
            vidaAtual -=1 ;
            int index = vidaAtual;
            Destroy(vida[index]);
            
        }
       
    }
}
