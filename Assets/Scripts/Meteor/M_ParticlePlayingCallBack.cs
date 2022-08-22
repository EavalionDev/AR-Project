using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_ParticlePlayingCallBack : MonoBehaviour
{
    private Transform particleObjectPool;
    private ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        particleObjectPool = GameObject.FindWithTag("ParticleObjectPool").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (ps.isPlaying)
        {
            return;
        }
        else
        {
            transform.position = particleObjectPool.position; 
        }
    }
}
