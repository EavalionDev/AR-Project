using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_CollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("Missile"))
        {
            //Destroy and increase money
        }
    }
}
