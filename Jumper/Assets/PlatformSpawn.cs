using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
    public GameObject platformPrefab;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < 10; i++)
        {
            spawnPosition.x = Random.Range(-5f, 5f);
            spawnPosition.y += Random.Range(1f, 3f);

            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
