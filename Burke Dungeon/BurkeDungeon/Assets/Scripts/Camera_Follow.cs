using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform Anna;
    void FixedUpdate()
    {
        transform.position = new Vector3(Anna.position.x, Anna.position.y, transform.position.z);
    }
}
