using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_CollisionHandler : MonoBehaviour
{
    [SerializeField] private M_ParticleObjectPool particleObjectPool;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private Transform objectPoolPosition;
    private void Awake()
    {
        particleObjectPool = GameObject.FindWithTag("ParticleObjectPool").GetComponent<M_ParticleObjectPool>();
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
            ps = particleObjectPool.meteorParticlePool[particleObjectPool.index];
            ps.transform.position = transform.position;
            ps.Play();
            transform.position = objectPoolPosition.position;
            gameObject.GetComponent<M_Movement>().outOfObjectPool = false;
            particleObjectPool.IncreaseIndex();
        }
    }
}
