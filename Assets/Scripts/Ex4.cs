using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    [SerializeField] int qtdpotion;
    
    void Start()
    {
        if (qtdpotion > 0)
        {
            print("Usando p���o");
            qtdpotion -= 1;

        }
        else
        {
            print("Po��o indisponivel");
        }
    }

    
    void Update()
    {
        
    }
}
