using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    Transform myTransform;
    public Transform target;
    public float offset_X, offset_Y, offset_Z;
    public float playerVelocity;
    float movementX, movementY, movementZ;


    void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        movementX = ((target.transform.position.x + offset_X - myTransform.position.x));
        movementY = ((target.transform.position.y + offset_Y - myTransform.position.y));
        movementZ = ((target.transform.position.z + offset_Z - myTransform.position.z));
        myTransform.position += new Vector3((movementX * playerVelocity * Time.deltaTime), 
            (movementY * playerVelocity * Time.deltaTime), 
            (movementZ * playerVelocity * Time.deltaTime));
    }
}