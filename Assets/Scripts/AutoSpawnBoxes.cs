using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpawnBoxes : MonoBehaviour
{

    public Transform[] spawnList;

    //Random rand = new Random();

    public GameObject[] obj;

    public float minSpawn = 0.5f;
    public float maxSpawn = 1.5f;

    float nextSpawn;
    float oldSpawn = 0;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawn = Random.Range(minSpawn, maxSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > oldSpawn + nextSpawn)
        {
            Spawn(Random.Range(0, obj.Length), Random.Range(0, spawnList.Length));
            nextSpawn = Random.Range(minSpawn, maxSpawn);
            oldSpawn = Time.time;
        }
    }

    void Spawn(int objIndex, int spawnPointIndex)
    {
        Instantiate(obj[objIndex], spawnList[spawnPointIndex].position, Quaternion.identity);
    }
}
