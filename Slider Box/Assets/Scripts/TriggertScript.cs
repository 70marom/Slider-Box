using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggertScript : MonoBehaviour
{
    public PlayerMovementAndCollision movement;
    public GameObject gameover;
    private void OnTriggerEnter(Collider other)
    {
        gameover.SetActive(true);
        movement.enabled = false;
    }


}
