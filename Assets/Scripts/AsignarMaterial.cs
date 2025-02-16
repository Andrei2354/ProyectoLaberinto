using UnityEngine;

public class AsignarMaterial : MonoBehaviour
{
    private Renderer objectRenderer; // Referencia al Renderer del objeto
    public Color colorRecogido = Color.green; // El color cuando se recoge la llave

    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // Obtén el Renderer del objeto

        if (objectRenderer == null)
        {
            Debug.LogError("El objeto no tiene un Renderer. Asegúrate de que tiene un MeshRenderer.");
        }
    }

    public void CambiarColorAlRecoger()
    {
        if (objectRenderer != null)
        {
            objectRenderer.material.color = colorRecogido; // Cambia el color del material al color definido
            Debug.Log("Color cambiado a recogido.");
        }
    }
}
