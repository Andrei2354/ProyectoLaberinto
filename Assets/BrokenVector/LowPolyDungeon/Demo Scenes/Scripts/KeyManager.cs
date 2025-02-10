using UnityEngine;

public class KeyManager : MonoBehaviour
{
    private int collectedFragments = 0; // Contador de fragmentos recogidos
    public int totalFragments = 3; // Total de fragmentos necesarios
    public GameObject door; // Referencia a la puerta

    public void CollectFragment(int fragmentID)
    {
        collectedFragments++; // Incrementa el contador de fragmentos
        Debug.Log($"Fragmento {fragmentID} recogido. Total: {collectedFragments}/{totalFragments}");

        if (collectedFragments >= totalFragments)
        {
            OpenDoor(); // Abre la puerta si se han recogido todos los fragmentos
        }
    }

    private void OpenDoor()
    {
        Debug.Log("¡Puerta abierta!");
        if (door != null)
        {
            door.SetActive(false); // Desactiva la puerta
            // Alternativamente, podrías activar una animación en vez de desactivarla
            // Animator doorAnimator = door.GetComponent<Animator>();
            // if (doorAnimator != null) doorAnimator.SetTrigger("Open");
        }
        else
        {
            Debug.LogError("No se ha asignado un objeto de puerta en KeyManager.");
        }
    }
}
