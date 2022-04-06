using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barryguard : MonoBehaviour
{
    private PlayerController _playercontroller;
     void OnCollisionEnter(Collision collision)
    {

        // getting the component of the collision object a
        _playercontroller = collision.gameObject.GetComponent<PlayerController>();
        // checking whether the component is available
        if (_playercontroller != null)
        {
           
            PlayerController.isDead = true;
            _playercontroller.deathAnimation();
        }
    }

   
}
