using UnityEngine;

public class Door : MonoBehaviour
{
    public KeyManager keyManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && keyManager != null)
        {
            if (keyManager.HasAllKeys())
            {
                Debug.Log("¡El jugador ha tocado la puerta con todas las llaves! Destruyendo puerta...");
                Destroy(gameObject);
            }
        }
    }
}


