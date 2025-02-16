using UnityEngine;

public class GeneradorConsumible : MonoBehaviour
{
    public GameObject consumible; // Referencia al consumible que se moverá
    public Vector3 centroRango = Vector3.zero; // Centro del rango fijo
    public Vector3 tamañoRango = new Vector3(10, 0, 10); // Tamaño del rango fijo (en X, Y, Z)

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que tocó el generador es el jugador
        if (other.CompareTag("Player"))
        {
            // Genera una posición aleatoria dentro del rango fijo
            Vector3 posicionAleatoria = new Vector3(
                centroRango.x + Random.Range(-tamañoRango.x / 2, tamañoRango.x / 2),
                centroRango.y + Random.Range(-tamañoRango.y / 2, tamañoRango.y / 2),
                centroRango.z + Random.Range(-tamañoRango.z / 2, tamañoRango.z / 2)
            );

            // Mueve el consumible a la posición aleatoria
            if (consumible != null)
            {
                consumible.transform.position = posicionAleatoria;
                Debug.Log("Consumible movido a: " + posicionAleatoria);
            }
            else
            {
                Debug.LogError("No se ha asignado el consumible.");
            }

            // Destruye el objeto actual
            Destroy(gameObject);
        }
    }
}