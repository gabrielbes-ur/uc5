using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour
{

    public float time;
    public GameObject meteoro;
    private float spawnRangeX = 3.5f;
    private float spawnPosZ = 0;
    private float startDelay = 2;
    private float spawnInterval = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMeteoro", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnMeteoro()
    {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(meteoro, spawnPos, meteoro.transform.rotation);
    }
}
