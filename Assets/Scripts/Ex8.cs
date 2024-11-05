using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex8 : MonoBehaviour
{
    public int cont;
    public int hora;
    int dias;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cont++;
        
        if (cont == 1000)
        {
            hora += 1;
            cont = 0;
        }

        if (hora == 24)
        {
            hora = 0;
            dias += 1;
            
        }
        print("O numero de dias passados foi " + dias);

    }
}
