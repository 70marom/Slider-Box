using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityLVL4 : MonoBehaviour
{
    Vector3 gravity;

    void Awake()
    {
        gravity = new Vector3(0, -33f, 0);
        Physics.gravity = gravity;
    }
}
