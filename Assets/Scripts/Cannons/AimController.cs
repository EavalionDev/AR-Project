using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimController : MonoBehaviour
{
    public Transform aimingPoint;

    private Camera cam;
    private Vector3 camCentre;
    private int layerMaskInt;
    // Start is called before the first frame update
    void Start()
    {
        //layerMaskInt = LayerMask.GetMask("Aiming Border");
        layerMaskInt = 1 << 6;
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //find the centre of the screen
        camCentre = cam.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, cam.nearClipPlane));
        //raycast out from centre of screen and place crosshair where it hits
        RaycastHit hit;
        if (Physics.Raycast(camCentre, transform.forward, out hit, 100f, layerMaskInt))
        {
            aimingPoint.position = hit.point;
        }

        Debug.DrawRay(camCentre, transform.forward * 100f, Color.red);
    }
}
