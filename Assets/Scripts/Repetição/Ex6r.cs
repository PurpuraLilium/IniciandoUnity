using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex6r : MonoBehaviour
{
    int num = 0;
    


    void Start()
    {
        while (num <= 10000)
        {
            num++;

            int tres = num % 3;
            int cinco = num % 5;


           
            if (tres == 0)
            {
                if (cinco == 0)
                {
                    print(num + " fizz buzz");
                }

                else
                {
                    print(num + " fizz");
                }
            }

            else if (cinco == 0)
            {
                print(num + " buzz");
            }

            else
            {
                print(num);
            }

        }
            
        
    }

    
    void Update()
    {
        
    }
}
