using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    private int collectedFragments = 0;
    public int totalFragments = 3;
    public GameObject door;
    public TextMeshProUGUI keyText; 

    void Start()
    {
        UpdateKeyText(); 
    }

    public void CollectFragment(int fragmentID)
    {
        collectedFragments++;
        Debug.Log($"Fragmento {fragmentID} recogido. Total: {collectedFragments}/{totalFragments}");
        UpdateKeyText(); 

        if (collectedFragments >= totalFragments){
            OpenDoor();
        }
    }

    private void UpdateKeyText(){
        if (keyText != null){
            keyText.text = $"Llaves: {collectedFragments}/{totalFragments}";
        }
    }

    private void OpenDoor()
    {
        Debug.Log("¡Puerta abierta!");
        if (door != null){
            door.SetActive(false);
        }
    }
}
