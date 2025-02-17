using UnityEngine;
using System.Collections.Generic;

public class KeySpawner : MonoBehaviour
{
    public GameObject keyFragmentPrefab;
    public int keysToSpawn = 3;
    private List<Vector3> spawnPositions = new List<Vector3>();
    private List<int> usedIndices = new List<int>();
    public List<GameObject> spawnedKeys = new List<GameObject>();

    private void Start()
    {
        InitializeSpawnPoints();
        SpawnKeys();
    }

    void InitializeSpawnPoints()
    {
        spawnPositions.Add(new Vector3(-27, -4, 5));
        spawnPositions.Add(new Vector3(-16, 1, -20));
        spawnPositions.Add(new Vector3(-29, 1, -28));
        spawnPositions.Add(new Vector3(-20, 6, -24));
        spawnPositions.Add(new Vector3(0, 11, -6));
        spawnPositions.Add(new Vector3(8, 6, 4));

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
            spawnedKeys.Add(key); 
        }
    }
}