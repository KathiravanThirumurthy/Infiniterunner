﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclehandler : MonoBehaviour
{
  
    [SerializeField]
    private GameObject _coinPrefab;
    [SerializeField]
    private GameObject _platformPrefab;
    [SerializeField]
    private GameObject _barryGuardPrefab;
    // Start is called before the first frame update
    void Start()
    {
          Invoke("loopingObstacles", 1);
       

    }

    private void loopingObstacles()
    {
        for (int i = 0; i < Random.Range(5, 15); i++)
        {
            createCoin();
        }
        
        for (int i = 0; i < Random.Range(0, 2); i++)
        {
            createBarryGuard();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void createCoin()
    {
        GameObject temp = Instantiate(_coinPrefab, new Vector3(Random.Range(-2.8f, 2.8f), 1, Random.Range(transform.position.z - 20, transform.position.z + 50)), Quaternion.identity);
        temp.transform.parent = _platformPrefab.transform;
    }
  /* private void createObstacle()
    {
       
        GameObject temp = Instantiate(_obstaclePrefab, new Vector3(Random.Range(-2.0f, 2.0f), 0.5f, Random.Range(transform.position.z - 20, transform.position.z + 20)), Quaternion.identity);
        temp.transform.parent = _platformPrefab.transform;
    }*/
   /* private void createFire()
    {
        Debug.Log("fire");
        // GameObject temp = Instantiate(_obstaclePrefab, new Vector3(Random.Range(-2.0f, 2.0f), 1, Random.Range(transform.position.z - 20, transform.position.z + 20)), Quaternion.identity);
        //temp.transform.parent = gameObject.transform;
        GameObject temp = Instantiate(_firePrefab, new Vector3(Random.Range(-2.0f, 2.0f),1, Random.Range(transform.position.z -20, transform.position.z + 20)), Quaternion.identity);
        temp.transform.parent = _platformPrefab.transform;
    }*/
    private void createBarryGuard()
    {
        GameObject temp;
        if (_barryGuardPrefab.name == "barrier1")
        {
             temp = Instantiate(_barryGuardPrefab, new Vector3(Random.Range(-2.9f, -0.8f), 0.2f, Random.Range(transform.position.z - 20, transform.position.z + 50)), Quaternion.identity);
        }
        else
        {
            temp = Instantiate(_barryGuardPrefab, new Vector3(Random.Range(-0.1f, 0.2f), -0.05f, Random.Range(transform.position.z - 20, transform.position.z + 80)), Quaternion.identity);
        }
        
        temp.transform.parent = _platformPrefab.transform;
    }
}
