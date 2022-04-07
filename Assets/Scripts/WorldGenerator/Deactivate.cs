using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Deactiviating Platform script
/// </summary>
public class Deactivate : MonoBehaviour
{
   // to check 
   private bool deactivated = false;
    private void OnCollisionExit(Collision player)
    {
        // if the Player is dead return out of the function
        if (PlayerController.isDead) return; 
        // checking for collision exit of the Player from the platform so that it can be deactivated
        if (player.gameObject.tag == "Player" && !deactivated)
        {
            //calling the SetInactive method to deactivate 
            Invoke("SetInactive", 4.0f);
            deactivated = true;

        }


    }
    void SetInactive()
    {
        //making the gameobject setactive to false
        this.gameObject.SetActive(false);
        // resetting deactivating schedule
        deactivated = false;
    }
   
}
