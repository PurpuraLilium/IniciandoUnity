using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Desafio1 : MonoBehaviour
{

    
    [SerializeField] string texto;


    void Start()
    {
        string txt = texto.ToLower();

        char[] letras = txt.ToCharArray();

        
        int cons = 0;


        foreach (char let in letras)
        {
          if (let == 'b' || let == 'c' || let == 'd' || let == 'f' || let == 'g' || let == 'h' || let == 'j' || let == 'k' || let == 'l' || let == 'm' || let == 'n' || let == 'p' || let == 'q' || let == 'r' || let == 's' || let == 't' || let == 'v' || let == 'w' || let == 'x' || let == 'y' || let == 'z')
            {
                cons += 1;
            }
            
        }
        print(cons);
    }

    
    void Update()
    {
        
    }
}
