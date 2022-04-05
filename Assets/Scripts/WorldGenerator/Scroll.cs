using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
   // private PlayerController _playerController;
    
    void FixedUpdate()
    {
        if (PlayerController.isDead) return;
        // transform.Translate(Vector3.forward *-5.0f* Time.deltaTime); 
        this.transform.position += PlayerController._player.transform.forward * -0.4f;
       

    }
}
