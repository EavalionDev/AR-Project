using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTimer : MonoBehaviour
{
    public M_ObjectPool objectPool;
    public GameObject meteor;

    private float timeUntilSpawn;
    private float count;
    [SerializeField] private GameObject chosenMeteorObject;
    private int objectPoolIndex;
    // Start is called before the first frame update
    void Start()
    {
        objectPoolIndex = 0;
        chosenMeteorObject = null;
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
        if (objectPoolIndex == 20)
        {
            objectPoolIndex = 0;
        }
    }
    void SpawnMeteor()
    {
        //Instantiate(meteor, transform.position, Quaternion.identity);
        chosenMeteorObject = objectPool.meteorPool[objectPoolIndex];
        chosenMeteorObject.transform.position = transform.position;
        chosenMeteorObject.GetComponent<M_Movement>().outOfObjectPool = true;
        timeUntilSpawn = Random.Range(3f, 10f);
        count = 0;
        objectPoolIndex++;
    }
}
