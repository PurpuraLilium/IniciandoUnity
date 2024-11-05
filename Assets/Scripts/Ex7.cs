using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex7 : MonoBehaviour
{
    [SerializeField] int numfaces;
    void Start()
    {
      int result = Random.Range(1, numfaces);
        print(result);
    }

    
    void Update()
    {
        
    }
}
