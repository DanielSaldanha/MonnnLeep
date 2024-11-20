using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDialogo : MonoBehaviour
{
   public GameObject DialogoOBJ;
   public Image profile;
   public Text speechTXT;
   public Text Name;
    string sentences;
  public void Speech(Sprite p, string txt, string actroname)
    {
        DialogoOBJ.SetActive(true);//aparece e disapareces
        profile.sprite = p;
        sentences = txt;
        Name.text = actroname;
    }

}
