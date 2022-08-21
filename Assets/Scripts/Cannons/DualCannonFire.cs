using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DualCannonFire : MonoBehaviour
{
    public GameObject missile;
    public Transform spawnerLeft;
    public Transform spawnerRight;

    private Transform crosshair;
    private GameObject spawnedMissileLeft;
    private GameObject spawnedMissileRight;
    [SerializeField] private bool hasFired;
    [SerializeField] private float fireDelayTime;
    private void Start()
    {
        hasFired = false;
        crosshair = GameObject.FindWithTag("Crosshair").transform;
    }
    public void FireCannon()
    {
        if (hasFired)
        {
            return;
        }
        else
        {
            spawnedMissileLeft = Instantiate(missile, spawnerLeft.position, Quaternion.identity);
            spawnedMissileLeft.transform.LookAt(crosshair);
            spawnedMissileRight = Instantiate(missile, spawnerRight.position, Quaternion.identity);
            spawnedMissileRight.transform.LookAt(crosshair);
            hasFired = true;
            StartCoroutine(WaitBeforeCanFireAgain());
        }
    }
    IEnumerator WaitBeforeCanFireAgain()
    {
        yield return new WaitForSeconds(fireDelayTime);
        hasFired = false;
    }
}
