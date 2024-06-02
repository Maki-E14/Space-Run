using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneraOstacolo2 : MonoBehaviour
{
    public GameObject ostacolo;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;  //tempo necessario per generare il prossimo ostacolo
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(ostacolo, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
