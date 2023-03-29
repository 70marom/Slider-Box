using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultGravity : MonoBehaviour
{
    Vector3 gravity;

    void Awake()
    {
        gravity = new Vector3(0, -20f, 0);
        Physics.gravity = gravity;
    }
}
