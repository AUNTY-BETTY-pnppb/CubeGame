//PLAYERMOVEMENT
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;    // RigidBody component of player
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    /*void Start()
    {
        UnityEngine.Debug.Log("Hello World!");
        rb.useGravity = false; // Don't use gravity
    }
    */

    // Update is called once per frame
    void FixedUpdate()  // Use FixedUpdate when dealing with physics
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // adds forward force

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().EndGame();
        }

    }
}