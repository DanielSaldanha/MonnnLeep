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
    [SerializeField] string[] sentences;
    [SerializeField] int index;
    [SerializeField] char letterControler;//apenas para fins estudantis
   
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
        foreach(char letter in sentences[index].ToCharArray())//o char todo mundo conhece ()ele armazena  so 1 charactere, uma letra so ou um numero)
        {
            speechTXT.text += letter;
            //toda frase DEVE terminar com um ponto final (de verificador)
            if(letter == '.')
            {
                letterControler = letter;
            }
            else
            {
                letterControler = 'b';
            }
            
            
            yield return new WaitForSeconds(speedTXT);

        }
    }
    
    public void nextControl()
    {
        if (speechTXT.text == sentences[index])// < letter2 == '.' > (tambem serve ein)
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
        
        if (letterControler == '.')
        {
            index = 0;
            speechTXT.text = "";
            DialogoOBJ.SetActive(false);
        }
        
       

    }

}
