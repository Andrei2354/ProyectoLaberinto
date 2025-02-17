using UnityEngine;

public class AsignarMaterial : MonoBehaviour
{
    private Renderer objectRenderer; 
    public Color colorRecogido = Color.green; 

    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); 

        if (objectRenderer == null)
        {
            Debug.LogError("El objeto no tiene un Renderer. Asegúrate de que tiene un MeshRenderer.");
        }
    }

    public void CambiarColorAlRecoger()
    {
        if (objectRenderer != null)
        {
            objectRenderer.material.color = colorRecogido; 
            Debug.Log("Color cambiado a recogido.");
        }
    }
}
