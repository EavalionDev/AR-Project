using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingSpawner : MonoBehaviour
{
    public Transform rotateAroundThisTransform;

    [SerializeField] private float rotateSpeed;
    [SerializeField] private bool hitBarrier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!hitBarrier)
        {
            transform.RotateAround(rotateAroundThisTransform.position, Vector3.up, rotateSpeed * Time.fixedDeltaTime);
        }
        else
        {
            transform.RotateAround(rotateAroundThisTransform.position, -Vector3.up, rotateSpeed * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnBarrier"))
        {
            if (hitBarrier)
            {
                hitBarrier = false;
            }
            else
            {
                hitBarrier = true;
            }
        }
    }
}
