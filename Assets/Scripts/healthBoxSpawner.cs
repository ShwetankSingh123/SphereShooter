using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBoxSpawner : MonoBehaviour
{
    public GameObject healthBox;
    public Transform ground;
    public float delay = 3.0f;

    private void Start()
    {
        InvokeRepeating("SpawnHealthBox", 0.0f, delay);
    }

    void SpawnHealthBox()
    {
        float xPos = Random.Range(-1.0f, 1.0f) * (ground.localScale.x / 2);
        float zPos = Random.Range(-1.0f, 1.0f) * (ground.localScale.z / 2);
        Vector3 SpawnPos = new Vector3(xPos, 1, zPos);
        Instantiate(healthBox, SpawnPos, Quaternion.identity);
    }
}
