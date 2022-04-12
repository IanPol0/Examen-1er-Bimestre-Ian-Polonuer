using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    public int cantidadTaxis;
    public int cantTotalDias;
    int CantDiasNormales;
    public int cantLluvia;
    int totalkm;
    int CostoNafta;

    // Start is called before the first frame update
    void Start()
    {
        
        if (cantidadTaxis < 5 || cantLluvia > cantTotalDias)
        {
            Debug.Log("Error: No se puede calcular el costo de la nafta");
        }

        else
        {
            CantDiasNormales = cantTotalDias - cantLluvia;
            totalkm = (CantDiasNormales * 90) + (cantLluvia * 110);
            CostoNafta = (totalkm / 15) * 130;

            Debug.Log("una flota de " + cantidadTaxis + " unidades trabanajndo durante " + cantTotalDias + " dias implicará un gasto de " + CostoNafta + " pesos Argentinos en concepto de combustible");
        }

    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
