using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mude : MonoBehaviour
{
    GameObject Clone;
    public GameObject Espinho;
    public Transform posiçao;
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Color haverColor;
    [SerializeField] bool inverter;
    Color startColor;

    int cu = 0;

    void Start()
    {
        startColor = sr.color;// vai pegar a primeira cor que ver
        LevelManager.mude += Inverçao;
        PlayerMoving.mude2 += Inverçao;
        inverter = true;
    }

   
    void Update()
    {
        if (inverter == false && cu == 0)
        {
            Cor2();
            Clone = Instantiate(Espinho, posiçao.position, Quaternion.identity);
            cu = 1;
        }
        if (inverter == true)
        {
            Cor1();
            Destroy(Clone);
            cu = 0;
        }
    }
    void Cor1()
    {
        sr.color = startColor;
    }
    void Cor2()
    {
        sr.color = haverColor;
    }
   public void Inverçao()
    {
        inverter = !inverter;
    }
}
