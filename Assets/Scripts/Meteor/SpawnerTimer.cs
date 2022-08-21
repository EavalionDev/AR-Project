using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTimer : MonoBehaviour
{
    public GameObject meteor;

    private float timeUntilSpawn;
    private float count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        timeUntilSpawn = Random.Range(3f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count >= timeUntilSpawn)
        {
            SpawnMeteor();
        }
    }
    void SpawnMeteor()
    {
        Instantiate(meteor, transform.position, Quaternion.identity);
        timeUntilSpawn = Random.Range(3f, 10f);
        count = 0;
    }
}
