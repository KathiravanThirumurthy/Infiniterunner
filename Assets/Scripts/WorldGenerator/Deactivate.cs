using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
   private bool deactivated = false;
    private void OnCollisionExit(Collision player)
    {
        
        if (PlayerController.isDead) return; 
        if (player.gameObject.tag == "Player" && !deactivated)
        {
            
            Invoke("SetInactive", 4.0f);
            deactivated = true;

        }


    }
    void SetInactive()
    {
        //PlatformPoolmanager._instance.ReturnObjecttoPool(transform.parent.gameObject);
        this.gameObject.SetActive(false);
        deactivated = false;
    }
   
}
