using UnityEngine;

public class GeneradorConsumible : MonoBehaviour
{
    public GameObject consumible; 
    public Vector3 centroRango = Vector3.zero;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (consumible != null)
            {
                consumible.transform.position = centroRango;
                Debug.Log("Consumible movido a: " + centroRango);
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