using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private float count;
    private void Start()
    {
        count = 0;
    }
    private void Update()
    {
        count += Time.deltaTime;
        if (count > 10f)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Meteor"))
        {
            Destroy(gameObject);
        }
    }
}
