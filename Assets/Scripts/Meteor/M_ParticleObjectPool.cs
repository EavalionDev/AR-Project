using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_ParticleObjectPool : MonoBehaviour
{
    public List<ParticleSystem> meteorParticlePool = new List<ParticleSystem>();
    public int index;

    private void Start()
    {
        index = 0;
    }
    private void Update()
    {
        if (index == 19)
        {
            index = 0;
        }
    }
    public void IncreaseIndex()
    {
        index++;
    }

}
