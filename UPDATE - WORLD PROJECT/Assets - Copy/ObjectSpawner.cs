using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefab;  // Reference to the prefab

    void Start()
    {
        Vector3 spawnPosition = new Vector3(-0.92f, 0.1f, 2.19f);  // Example custom position
        Quaternion spawnRotation = Quaternion.Euler(-87.064f, 0, 0);  // Example custom rotation
        Instantiate(prefab, spawnPosition, spawnRotation);
    }

}
