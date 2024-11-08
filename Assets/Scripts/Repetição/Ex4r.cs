using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4r : MonoBehaviour
{
    int point = 10;
    int combo = 1;
    void Start()
    {
        while (combo <= 7)
        {
            print("Combo x" + combo + ", seus pontos são: " + point);
            combo++;
            point += 10;
        }

        
    }

    void Update()
    {
        
    }
}
