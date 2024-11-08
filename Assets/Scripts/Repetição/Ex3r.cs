using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3r : MonoBehaviour
{
    int fase = 1;
    int coin = 3;
    void Start()
    {
        while (fase <= 10)
        {
            print("Fase " + fase + ", moedas coletadas: " + coin);
            coin += 3;
            fase++;
        }
    }

    void Update()
    {
        
    }
}
