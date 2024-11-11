using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex8r : MonoBehaviour
{
    [SerializeField] string nome;
    string emon;
    

    void Start()
    {
        for (int i = nome.Length-1; i >= 0 ; i-- )
        {
            emon += nome[i];
        }

        print(emon);
    }



    void Update()
    {
        
    }
}
