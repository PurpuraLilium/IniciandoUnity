using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex7 : MonoBehaviour
{
    [SerializeField] int numfaces;
    void Start()
    {
        if (numfaces <= 0)
        {
            print("Não é possível um dado ter esse numero de faces.");
        }
        else
        {
            int result = Random.Range(1, numfaces);
            print("O resultado foi: " + result);
        }
      
    }

    
    void Update()
    {
        
    }
}
