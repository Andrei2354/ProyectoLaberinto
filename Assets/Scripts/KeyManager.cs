using UnityEngine;
using TMPro;

public class KeyManager : MonoBehaviour
{
    private int collectedFragments = 0;
    public int totalFragments = 3;
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
    }

    private void UpdateKeyText()
    {
        if (keyText != null)
        {
            keyText.text = $"Llaves: {collectedFragments}/{totalFragments}";
        }
    }

    public bool HasAllKeys()
    {
        return collectedFragments >= totalFragments;
    }
}

