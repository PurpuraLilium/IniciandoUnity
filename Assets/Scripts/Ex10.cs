using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex10 : MonoBehaviour
{
    [SerializeField] int Item;
    public int qtdmoeda;
    public int qtdvida;
    public int velocida;
    void Start()
    {
        switch (Item) 
        {
            case 1:
                print("Moeda coletada");
                qtdmoeda++;
                break;

            case 2:
                print("Poção coletada, vida aumentada");
                qtdvida += 10;
                break;

            case 3:
                print("Power-up coletado, velocidade aumentada");
                velocida += 5;
                break;
        }
    }

    
    void Update()
    {
        
    }
}
