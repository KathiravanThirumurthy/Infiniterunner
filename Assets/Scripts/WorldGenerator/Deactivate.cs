using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
  
    private void OnCollisionExit(Collision player)
    {
        if (PlayerController.isDead) return; 
        if (player.gameObject.tag == "Player" )
        {
            
            Invoke("SetInactive", 1.0f);
            
        }


    }
    void SetInactive()
    {
        PlatformPoolmanager._instance.ReturnObjecttoPool(transform.parent.gameObject);
     }
   
}
