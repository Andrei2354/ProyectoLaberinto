using UnityEngine;
using System.Collections.Generic;

public class ControladorDeLlaves : MonoBehaviour
{
    private List<AsignarMaterial> llaves = new List<AsignarMaterial>(); // Lista para almacenar todas las llaves

    // Método que se llama al registrar una nueva llave
    public void RegistrarLlave(AsignarMaterial llave)
    {
        if (!llaves.Contains(llave))
        {
            llaves.Add(llave); // Agrega la llave a la lista
        }
    }

    // Método que cambia el color de todas las llaves registradas
    public void CambiarColorDeTodasLasLlaves()
    {
        foreach (AsignarMaterial llave in llaves)
        {
            llave.CambiarColorAlRecoger(); // Llama a CambiarColorAlRecoger de cada llave
        }
    }
}
