using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    [SerializeField] int dia;
    [SerializeField] int mes;
    [SerializeField] int ano;
    
    void Start()
    {
        int year = System.DateTime.Now.Year;
        int month = System.DateTime.Now.Month;
        int day = System.DateTime.Now.Day;

        int diaTotal = 1;

        while (ano <= year && mes <= month && dia <= day)
        {
            dia++;

            if (dia == 30)
            {
                dia = 1;
                mes++;
            }
            if (mes == 12)
            {
                mes = 1;
                ano++;
            }
            
            diaTotal++;
        }

        print(dia);
        print(diaTotal);

    }

    
    void Update()
    {
        
    }
}
