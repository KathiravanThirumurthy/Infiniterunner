using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinrotate : MonoBehaviour
{
    // declaring the variable for score
    private int _score;
    // Intializing the playercontroller
    private PlayerController _playercontroller;
    
    [SerializeField]
    private float _speed=4.0f;
    [SerializeField]
    private GameObject _particlePrefab;
    // Start is called before the first frame update
    void Awake()
    {
        _score = 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30,45)*_speed*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        // getting the component of the collision object a
        _playercontroller = collision.gameObject.GetComponent<PlayerController>();
        // checking whether the component is available
        if (_playercontroller != null)
        {
            // on getting the component calling the pickup key method from PlayerController
            _playercontroller.pickUpCoin(_score);
            Instantiate(_particlePrefab, this.gameObject.transform.position, Quaternion.identity);
           
            //after collision destroying the collectable item
            Destroy(this.gameObject ,10);
        }
    }
}
