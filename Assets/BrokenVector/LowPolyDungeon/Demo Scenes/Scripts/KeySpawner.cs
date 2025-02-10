using UnityEngine;
using System.Collections.Generic;

public class KeySpawner : MonoBehaviour
{
    public GameObject keyFragmentPrefab;
    public int keysToSpawn = 3; 
    private List<Vector3> spawnPositions = new List<Vector3>();
    private List<int> usedIndices = new List<int>(); 

    private void Start()
    {
        InitializeSpawnPoints();
        SpawnKeys();
    }

    void InitializeSpawnPoints()
    {
        spawnPositions.Add(new Vector3(0f, 1f, 0f));   
        spawnPositions.Add(new Vector3(3f, 1f, 5f));  
        spawnPositions.Add(new Vector3(-4f, 1f, 2f)); 
        spawnPositions.Add(new Vector3(5f, 1f, -3f));  
        spawnPositions.Add(new Vector3(-2f, 1f, -5f)); 
        spawnPositions.Add(new Vector3(7f, 1f, 4f));   
        spawnPositions.Add(new Vector3(-6f, 1f, -2f)); 

        Debug.Log("Puntos de spawn inicializados: " + spawnPositions.Count);
    }

    void SpawnKeys()
    {
        if (spawnPositions.Count < keysToSpawn)
        {
            Debug.LogError("No hay suficientes ubicaciones para colocar las llaves.");
            return;
        }

        for (int i = 0; i < keysToSpawn; i++)
        {
            int randomIndex;
            do
            {
                randomIndex = Random.Range(0, spawnPositions.Count);
            }
            while (usedIndices.Contains(randomIndex)); 
            usedIndices.Add(randomIndex);

            GameObject key = Instantiate(keyFragmentPrefab, spawnPositions[randomIndex], Quaternion.identity);
            key.GetComponent<KeyFragment>().fragmentID = i + 1;
        }
    }
}
