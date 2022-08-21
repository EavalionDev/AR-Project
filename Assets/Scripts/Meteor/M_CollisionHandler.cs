using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_CollisionHandler : MonoBehaviour
{
    [SerializeField] private Transform objectPoolPosition;

    private void Awake()
    {
        objectPoolPosition = GameObject.FindWithTag("MeteorObjectPool").transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.position = objectPoolPosition.position;
            gameObject.GetComponent<M_Movement>().outOfObjectPool = false;
        }
        else if (other.CompareTag("Missile"))
        {
            //Destroy and increase money
            transform.position = objectPoolPosition.position;
            gameObject.GetComponent<M_Movement>().outOfObjectPool = false;
        }
    }
}
