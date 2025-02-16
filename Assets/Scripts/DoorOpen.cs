using UnityEngine;

public class Door : MonoBehaviour
{
    public KeyManager keyManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && keyManager != null)
        {
            if (keyManager.HasAllKeys())
            {
                Debug.Log("¡El jugador ha tocado la puerta con todas las llaves! Destruyendo puerta...");
                Destroy(gameObject);
            }
        }
    }
}

