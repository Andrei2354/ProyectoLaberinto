using UnityEngine;

public class KeyFragment : MonoBehaviour
{
    public int fragmentID; // Identificador único para cada fragmento (1, 2, 3)
    private KeyManager keyManager; // Referencia al script que maneja los fragmentos
    private bool collected = false; // Evita recolecciones dobles

    private void Start()
    {
        // Busca automáticamente el KeyManager en la escena
        keyManager = FindObjectOfType<KeyManager>();
        if (keyManager == null)
        {
            Debug.LogError("KeyManager no encontrado en la escena.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !collected)
        {
            collected = true; // Marcar como recogido
            keyManager.CollectFragment(fragmentID); // Notifica al KeyManager
            Destroy(gameObject); // Destruye el fragmento

            // Puedes agregar un sonido o partículas aquí si deseas
            // AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}

