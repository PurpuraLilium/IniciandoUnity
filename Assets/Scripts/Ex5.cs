using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    [SerializeField] int points;
    void Start()
    {
        if (points >= 50)
        {
            print("Missão bem sucedida");
        }

        else
        {
            print("Missão incompleta");
        }
    }

    
    void Update()
    {
        
    }
}
