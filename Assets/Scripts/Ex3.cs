using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    bool vivo;
    [SerializeField] int VidaPlayerTotal = 10;
    [SerializeField] int VidaPlayerAtual;
    [SerializeField] bool powerup;

    void Start()
    {
        

        if (powerup == true)
        {
            print("Power-up coletado");

        }
        else
        {
            print("Nenhum powerup-up encontrado");

        }

        
     }
  

    // Update is called once per frame
    void Update()
    {
        vivo = VidaPlayerAtual <= 0 ? false : true;

        if (vivo == false && powerup == true)
        {
            print("Morrendo");

            VidaPlayerAtual += VidaPlayerTotal/2;

            print($"Ainda não, vida atual " + VidaPlayerAtual);
        }
    }
}
