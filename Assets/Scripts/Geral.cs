using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geral : MonoBehaviour
{

    /*
    TIPOS DE VARIAVEL

    int = Numero inteiro

    float = Numero quebrado (colocar f no fim)

    double = O mesmo que o float, mas com maior armazenamento

    string = Conjunto de caracteres (usar ")

    char = Um unico caracter (usar ')

    bool = Verdadeiro ou falso

    ---------------------------------

    public = variavel que aparece e pode ser chamada em outros scripts

    private = variavel que s� � visivel no proprio script

    SerializeField = pode ser usada para tornar uma variavel privada visivel dentro da unity

    variaveis locais s� podem ser usadas dentro daquela fun��o (s�o definidas dentro do metodo)

    variavel global podem ser usadas em outras fun��es (s�o definidas fora do metodo)
    */

    /*
     OPERADOR TERN�RIO

    variavel = condi��o ? se verdade : se falso;
     */

    /*
     ARRAY

    tipo[] Variavel = {x , y , z , ...};
    ex:

    string[] nomes;
    nomes = new string[6]; //define o tamanho da lista
    nomes[0] = "Tadeu";

    ---------------------------------

    List<int> variavel = new List<int>()

    variavel.Add(coisa);
    veriavel.Remove(coisa);
    variavel.Sort //organiza a lista em ordem crescente
    variavel.Reverse //organiza a lista em ordem decrescente
    variavel.(IndexOf(itemdalista) //mostra o indice do elemnto da lista

     */


    /*
     LOOP

    for(Inicializador ; condi��o ; incremento/decremento)
    ex:
        for(int i = 0 ; i <= 10 ; i++)
    {
        print(i);
    }

    ---------------------------------

    while(condi��o)
    {
        a��o a se executar;
    }
    ex:
        while(x <= 10)
    {
            print(x);
            x++;
    }

    ---------------------------------

    do
    {
    (a��o a se executar)
    }
    while(condi��o);
    ex:
    do
    {
        print(y);
        y--
    }
    while(y <= 0);

    ---------------------------------

    foreach (var variavel1 in variavel2)
    {
    print(variavel1)
    }
     */

    /*
     
    */


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
