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

    public float speedTXT;
    string[] sentences;
    int index;
    void Start()
    {
        EndSpeech();
       
    }
  public void Speech(Sprite p, string[] txt, string actroname)
    {
        DialogoOBJ.SetActive(true);//aparece e disapareces
        profile.sprite = p;
        sentences = txt;
        Name.text = actroname;
        StartCoroutine(TypeSentence());
    }
    
    IEnumerator TypeSentence()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            speechTXT.text += letter;
            yield return new WaitForSeconds(speedTXT);

        }
    }
    
    public void nextControl()
    {
        if (speechTXT.text == sentences[index])
        {
            if(index < sentences.Length - 1)
            {
                index++;
                speechTXT.text = "";
                StartCoroutine(TypeSentence());
            }
            else
            {
                
                EndSpeech();
            }
           
        }
    }
    public void EndSpeech()
    {
        speechTXT.text = "";
        index = 0;       
        DialogoOBJ.SetActive(false);    
    }

}
