//PLAYERCOLLISION
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public playerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) // this function will be called when the object collides with another object
    {
        // UnityEngine.Debug.Log(collisionInfo.collider.name); // name of colliding object
        if (collisionInfo.collider.tag == "Obstacle") // tags to show identity of object
        {
            movement.enabled = false; // player stops moving
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}