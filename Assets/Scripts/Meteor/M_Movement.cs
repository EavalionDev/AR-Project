using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Movement : MonoBehaviour
{
    public bool outOfObjectPool;

    private Transform playerTransform;
    [SerializeField] private float dis;
    [SerializeField] private float travelSpeed;
    [SerializeField] private Vector3 addRotationValue;
    // Start is called before the first frame update
    void Start()
    {
        outOfObjectPool = false;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (!outOfObjectPool)
        {
            return;
        }
        else
        {
            dis = Vector3.Distance(playerTransform.position, transform.position);
            if (dis < 1f)
            {
                return;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, travelSpeed * Time.deltaTime);
            }
        } 
    }
    private void FixedUpdate()
    {
        transform.Rotate(addRotationValue * Time.fixedDeltaTime);
    }
}
