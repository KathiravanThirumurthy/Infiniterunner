using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static GameObject _player;
    private PlayerAnimation _playerAnimation;
    [SerializeField]
    private ScoreManager _ScoreManager;
    private Deactivate deactivate;
    private bool isDeactivated;
    private Animator _playerAnim;
    [SerializeField]
    private float _speed = 4.0f;
    [SerializeField]
    private float _jumpForce;
    private Rigidbody rgdPlayer;
    private bool isGrounded = false;
    public static bool isDead=false;
    public static PlayerController player;
    private bool atJump = false;
    
    // Start is called before the first frame update
    void Start()
    {

        rgdPlayer = GetComponent<Rigidbody>();
        _playerAnim =GetComponent<Animator>();
        _playerAnimation = GetComponent<PlayerAnimation>();
        _ScoreManager = GameObject.Find("Canvas").GetComponent<ScoreManager>();
        _player = this.gameObject;



    }

    // Update is called once per frame
    void Update()
    {


        if (PlayerController.isDead) return;
        //  playerMovement();
        float yInput = Input.GetAxis("Vertical");
        float xInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(xInput, yInput, 0);
        transform.Translate(direction * _speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                //adding velocity to the player in the y direction to jump
                rgdPlayer.velocity = new Vector2(rgdPlayer.velocity.x, _jumpForce);

                // when the player is in air it Space bar shouldnt be pressed 
                isGrounded = false;
                // calling the jumping method from the PlayerAnimation Script
                _playerAnimation.jumping(true);
            }
        }/*else if(Input.GetKeyDown(KeyCode.M))
        {

            _playerAnimation.castSpell(true);
        }else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("rt");
            // this.transform.Rotate(Vector3.up * 90);
            transform.Translate(Vector3.forward * xInput*_speed * Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // this.transform.Rotate(Vector3.up * -90);
            transform.Translate(Vector3.forward * xInput*_speed * Time.deltaTime);
        }*/
    }
    
    private void playerMovement()
    {

        float yInput = Input.GetAxis("Vertical");
        float xInput = Input.GetAxis("Horizontal");
        
        
       // transform.Translate(Vector3.right * xInput * _speed * Time.deltaTime);
       // transform.Translate(Vector3.forward * yInput * _speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        // if the player collides with Ground with tag "Platform"
        if (collision.gameObject.tag == "Platform")
        {
            // to check Grounded
            isGrounded = true;
            // calling the jumping method from the PlayerAnimation Script to jump
            _playerAnimation.jumping(false);
        }
        else if (collision.gameObject.tag == "Fire")
        {
             //Debug.Log("Dead");
            _playerAnimation.deadAnimation();
            isDead = true;

        }
        else if (collision.gameObject.tag == "Endplatform")
        {
            Debug.Log("Dead");
            

        }

    }

   /* private void OnTriggerEnter(Collider track)
    {
        if (track.gameObject.tag == "Endplatform")
        {

            //Deactivate.deactivated = false;
            atJump = true;
            Debug.Log("EndPlatform");
           

        }
    }*/

   private void OnCollisionExit(Collision track)
    {
      //if (collision.gameObject.tag == "Endplatform"
       
       if (track.gameObject.tag == "Platform")
        {

           
            PlatformPoolmanager._instance.getObjectFromPool(new Vector3(0, 0, track.transform.position.z+40.0f), transform.rotation);
          
        }

    }
    public void pickUpCoin(int score)
    {
       // Debug.Log(score);
       _ScoreManager.incrementScore(score);
    }

}
