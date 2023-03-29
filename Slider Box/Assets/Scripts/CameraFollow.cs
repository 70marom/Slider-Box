using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 axis;

    public void Update()
    {
        // transform = transform of this gameobject, camera.
            transform.position = player.position + axis;
        
    }
}
