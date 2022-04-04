using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    private void Awake()
    {
        //Getting Animator component from Inspector panel
        anim = GetComponent<Animator>();
    }
    public void jumping(bool jumping)
    {
        // checking for the jumping animation with SetBool method in the Animator panel
        anim.SetBool("isJump", jumping);
       // Debug.Log(jumping);
    }
    public void deadAnimation()
    {
        // checking for the dead animation with SetTrigger method in the Animator panel
        anim.SetTrigger("isDead");
       
    }
    public void castSpell(bool magic)
    {
        anim.SetBool("isMagic", magic);
    }
}
