using UnityEngine;
using System.Collections.Generic;

public class ControladorDeLlaves : MonoBehaviour
{
    private List<AsignarMaterial> llaves = new List<AsignarMaterial>(); 


    public void RegistrarLlave(AsignarMaterial llave)
    {
        if (!llaves.Contains(llave))
        {
            llaves.Add(llave);
        }
    }


    public void CambiarColorDeTodasLasLlaves()
    {
        foreach (AsignarMaterial llave in llaves)
        {
            llave.CambiarColorAlRecoger(); 
        }
    }
}
