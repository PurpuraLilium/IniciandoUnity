using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Ex5r : MonoBehaviour
{
    int fase = 1;
    int dif = 5;
    // Start is called before the first frame update
    void Start()
    {
        while (fase <= 6)
        {
            print("Fase atual" + fase + ", difículdade em: " + dif + " pontos");
            fase++;
            dif += 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
