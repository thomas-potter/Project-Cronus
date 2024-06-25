using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtRotation : MonoBehaviour
{
    [SerializeField] GameObject camObject;
    Camera cam;
    [SerializeField] float offset = 0.1f;
    float LookAtHeight = 0.22f;

    void Start()
    {
        cam = camObject.GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        //grabbing mouse point
        Vector3 MousePos = (cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5)));
        LookAtHeight = transform.position.y;
        Vector3 MousePosLocked = new Vector3(MousePos.x, LookAtHeight, MousePos.z);

        //Rotation
        Vector3 direction = MousePosLocked - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        Quaternion rot = new Quaternion(0, rotation.y, 0, rotation.w);
        transform.rotation = rot;
    }
}
