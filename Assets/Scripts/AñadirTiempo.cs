using UnityEngine;

public class AñadirTiempo : MonoBehaviour
{
    public float tiempoExtra = 10f; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Timer timerScript = FindObjectOfType<Timer>();
            if (timerScript != null)
            {
                timerScript.AñadirTiempo(tiempoExtra);
            }

            Destroy(gameObject);
        }
    }
}
