using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ex7r : MonoBehaviour
{
    int[] numeros = {0 , 10 , 37 , 57 , 21};
    int num;

    
    
    void Start()
    {
        num = numeros[0];

        foreach (int i in numeros)
        {
            if (num < i)
            {
                num = i;
            }
        }
        print(num);



    }

    void Update()
    {
        
    }
}
