using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6 : MonoBehaviour
{
    [SerializeField] int character;
    void Start()
    {
        switch (character)
        {
            case 1:
                print("Guerreiro escolhido");
                break;
            case 2:
                print("Mago escolhido");
                break;
        }
    }

    void Update()
    {
    }
}
