using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private GameObject _gunPos;
    [SerializeField]
    private float _speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       // Shooting();
        playerMovement();

    }
    private void playerMovement()
    {

        float yInput = Input.GetAxis("Vertical");
        float xInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * xInput * _speed * Time.deltaTime);
        transform.Translate(Vector3.forward * yInput * _speed * Time.deltaTime);
    }
    private void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate(_bulletPrefab, this.transform.position, Quaternion.identity);
            // because we are instantiating objects from Pool
           // Bulletpool._instance.getObjectFromPool(_gunPos.transform.position, _gunPos.transform.rotation);
        }
    }



}










