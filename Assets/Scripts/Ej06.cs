using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
//en una variable llamada num1 y muestre un mensaje por pantalla indicando "el número es
//par" "el número es impar." Deberá utilizar el operador “módulo” es el caracter %.

public class Ej06 : MonoBehaviour
{
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 <= 0)
        {
            Debug.Log("El número debe ser mayor a 0");
        }
        else if (num1 % 2 == 0)
        {
            Debug.Log("El número " + num1 + "es par");
        }
        else
        {
            Debug.Log("El número " + num1 + "es impar");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
