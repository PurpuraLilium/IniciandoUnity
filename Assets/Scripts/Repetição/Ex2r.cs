using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2r : MonoBehaviour
{
    int dano = 5;
    int atk = 1;
    void Start()
    {
        
        while (atk <= 5)
        {
            print(dano);
            atk++;
            dano += 2;
        }
    }

    void Update()
    {
        
    }
}
