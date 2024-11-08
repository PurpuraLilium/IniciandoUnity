using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex11 : MonoBehaviour
{
    [SerializeField] int opcao;
    void Start()
    {
        print("Bem-vindo! O que vai ser hoje?");
        print("[Op1]: Comprar - [Op2]: Vender - [Op3]: Sair");

    }

    void Update()
    {
        switch (opcao)
        {
            case 1:
                print("O que vai comprar?");
                break;

            case 2:
                print("O que vai vender?");
                break;

            case 3:
                print("Adeus");
                break;
        }
    }
}
