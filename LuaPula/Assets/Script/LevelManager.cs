using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public delegate void Mensagem();
    public static Mensagem mude;
    //Mude m;
   // LevelManager l;
    void Start()
    {
     //   m = FindObjectOfType<Mude>();
     //   l = FindObjectOfType<LevelManager>();

      //  l.mude += m.Inver�ao;
    }

   
    void Update()
    {
       
      
    }
    public void Inver�ao()
    {
        if (mude != null)
        {
            mude();
        }
    }
}
