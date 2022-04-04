using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    private float smoothSpeed = 0.125f;
    [SerializeField]
    private Vector3 offset;
    [SerializeField]
    private float offsetX = -5.0f;
    [SerializeField]
    private float offsetY = -5.0f;
    private void LateUpdate()
    {
       
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, player.position.z + offset.z);
       

    }
}
