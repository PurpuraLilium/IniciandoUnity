using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Desafio1 : MonoBehaviour
{

    
    [SerializeField] string texto;
    
    List<char> letras = new List<char>();

    

    


    void Start()
    {

        char[] letras = texto.ToCharArray();

        
        int cons = texto.Length;


        foreach (char let in letras)
        {
          if (let == 'a' || let == 'e' || let == 'i' || let == 'o' || let == 'u')
            {
                cons --;
            }
            
        }
        print(cons);
    }

    
    void Update()
    {
        
    }
}
