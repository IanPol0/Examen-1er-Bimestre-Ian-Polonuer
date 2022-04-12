//Una flota de taxis tiene una cantidad determinada de unidades. Se calcula que cada unidad 
//recorre unos 90 km por día y que cada litro de combustible permite recorrer 15 km. 
//Se calcula también que los días de lluvia se trabaja más, llegando a un recorrido de 110 km 
//por unidad. Teniendo en cuenta que el litro de combustible cuesta $130, debemos hacer un programa
//que nos permita calcular el costo del combustible para una flota completa de taxis en un período 
//de días determinado.

//Se requiere el ingreso por Inspector de la cantidad de unidades que tiene la flota, la 
//cantidad total de días y una cantidad de días de lluvia a tener en cuenta.


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    public int cantidadTaxis;
    public int cantTotalDias;
    public int cantLluvia;

    int totalkm;
    int CostoNafta;
    int CantDiasNormales;

    // Start is called before the first frame update
    void Start()
    {
        //El programa debe devolver un mensaje de error y no realizar ningún cálculo si 
        //la cantidad de días total es menor que 5 o si la cantidad de días de lluvia es 
        //negativa o mayor que la cantidad total de días.
        if (cantidadTaxis < 5 || cantLluvia > cantTotalDias || cantLluvia < 0) 
        {
            Debug.Log("Error: No se puede calcular el costo de la nafta");
        }

        //El programa debe devolver la información calculada mediante un mensaje en el siguiente formato:
        //“Una flota de[cantidadDeUnidades] unidades trabajando durante[periodoDeDias] días implicará un 
        //gasto de[costoTotalCombustible] pesos en concepto de combustible”.
        else
        {
            CantDiasNormales = cantTotalDias - cantLluvia;
            totalkm = (CantDiasNormales * 90) + (cantLluvia * 110);
            CostoNafta = cantidadTaxis*((totalkm / 15) * 130);

            Debug.Log("Una flota de " + cantidadTaxis + " unidades trabanajndo durante " + cantTotalDias + " dias implicará un gasto de " + CostoNafta + " pesos argentinos en concepto de combustible");
        }

    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
