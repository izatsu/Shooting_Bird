using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefabsBird;
    private float spawnTime = 2.0f;
    public Transform parrentBird;
    public Transform parrentPosition;

    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime < 0)
        {
            Vector3 positionSpawn = parrentPosition.position;
            positionSpawn.x = Random.Range(-9.5f, 9.5f);
            positionSpawn.y = Random.Range(-5.3f, 5.3f);
            Instantiate(prefabsBird, positionSpawn, Quaternion.identity, parrentBird);
            spawnTime = Random.Range(2f,4f);

        }
    }
}
