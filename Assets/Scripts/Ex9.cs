using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ex9 : MonoBehaviour
{
    [SerializeField] int pontosA;
    [SerializeField] int pontosB;

    void Start()
    {
        if (pontosA > pontosB) {
            print("Vitória do time A");
        }
        else if (pontosB > pontosA)
        {
            print("vitória do time B");
        }
        else if (pontosA == pontosB)
        {
            if (pontosA == 3 && pontosB == 3)
            {
                print("Foi um empate emocionante");
            }
            else
            {
                print("Empate");
            }
        }
    }
    

    void Update()
    {
 
    }
}
