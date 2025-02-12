using UnityEngine;

public class KeyFragment : MonoBehaviour
{
    public int fragmentID;    private KeyManager keyManager;
    private bool collected = false; 

    private void Start()
    {

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
            collected = true; 
            keyManager.CollectFragment(fragmentID); 
            Destroy(gameObject); 
        }
    }
}

