using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Scrolling the Platform
/// </summary>
public class Scroll : MonoBehaviour
{
  
    void FixedUpdate()
    {
        // when the player is dead stopping the platform scrolling
        if (PlayerController.isDead) return;
        // transform.Translate(Vector3.forward *-5.0f* Time.deltaTime); 
        //moving the platform against the direction of the Player
        this.transform.position += PlayerController._player.transform.forward * -0.4f;
       

    }
}
