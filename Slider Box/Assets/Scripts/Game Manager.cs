using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Vector3 gravity;

    void Awake()
    {
        gravity = new Vector3(0, -9.81f, 0);
        Physics.gravity = gravity;
    }
}

