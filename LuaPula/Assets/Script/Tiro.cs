using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    [SerializeField] Rigidbody2D RB;
    [SerializeField] float Speed;

    public void Mova(Vector2 direcao)
    {
        RB.velocity = direcao * Speed;
    }
}
