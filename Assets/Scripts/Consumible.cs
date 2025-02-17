using UnityEngine;

public class Consumible : MonoBehaviour
{
    public Material nuevoMaterial; // Material que se aplicará a los clones
    public KeySpawner keySpawner;  // Referencia al script KeySpawner

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que tocó el consumible es el jugador
        if (other.CompareTag("Player"))
        {
            // Cambia el material de los clones generados por KeySpawner
            foreach (GameObject clone in keySpawner.spawnedKeys)
            {
                if (clone != null)
                {
                    Renderer renderer = clone.GetComponent<Renderer>();
                    if (renderer != null)
                    {
                        renderer.material = nuevoMaterial;
                    }
                }
            }

            // Destruye el consumible
            Destroy(gameObject);
        }
    }
}