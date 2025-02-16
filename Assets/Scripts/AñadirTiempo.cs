using UnityEngine;

public class AñadirTiempo : MonoBehaviour
{
    public float tiempoExtra = 10f; // Tiempo que se añadirá al temporizador

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el jugador lo toca
        {
            Timer timerScript = FindObjectOfType<Timer>(); // Encuentra el script Timer en la escena
            if (timerScript != null)
            {
                timerScript.AñadirTiempo(tiempoExtra); // Añade el tiempo extra
            }

            Destroy(gameObject); // Destruye el objeto tras recogerlo
        }
    }
}
