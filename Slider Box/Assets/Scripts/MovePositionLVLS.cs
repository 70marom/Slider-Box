using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MovePositionLVLS : MonoBehaviour
{
    public Rigidbody rb;
    public Collider coll;
    public float targetDistance;
    public float forceForward = 40000f;
    public float forceSide = 35f;
    public float forceUp = 1000f;
    public bool canJump = false;
    public LayerMask mask;
    public GameObject y;
    public MovePositionLVLS movement;
    public GameObject complete;
    public GameObject gameover;
    public GameObject playerDestroyed;
    public bool t = true;
    public AudioSource jumpSound;
    public AudioSource expSound;


    void Start()
    {
        InvokeRepeating("MoreSpeed", 7f, 5f);
    }
    void FixedUpdate()
    {
        
        Vector3 movePos = new Vector3(forceSide * Time.deltaTime, 0, 0);
        Vector3 mMovePos = new Vector3(-forceSide * Time.deltaTime, 0, 0);
        Vector3 forward = new Vector3(0, 0, forceForward * Time.deltaTime);
        if (t == true)
        {
            rb.MovePosition(transform.position + forward);

            if (Input.GetKey("a"))
            {
                //rb.MovePosition(transform.position + mMovePos);
                rb.AddForce(-forceSide * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("d"))
            {
                //rb.MovePosition(transform.position + movePos);
                rb.AddForce(forceSide * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (canJump == true)
            {
                if (Physics.Raycast(transform.position, Vector3.down, coll.bounds.extents.y + 0.1f, mask))
                {
                    jump();
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        canJump = true;
    }
    private void OnTriggerExit(Collider other)
    {
        canJump = false;
    }
    public void jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, forceUp * Time.deltaTime, 0, ForceMode.Impulse);
            jumpSound.Play();
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Obstacle")
        {
            t = false;
            rb.isKinematic = true;
            Instantiate(playerDestroyed, transform.position, transform.rotation);
            Instantiate(playerDestroyed, transform.position, transform.rotation);
            MeshRenderer m = y.GetComponent<MeshRenderer>();
            m.enabled = false;
            movement.enabled = false;
            gameover.SetActive(true);
            expSound.Play();

        }
        if (col.collider.tag == "Wall")
        {
            complete.SetActive(true);
        }
    }
    void MoreSpeed()
    {
        forceForward += 4;
    }
}
