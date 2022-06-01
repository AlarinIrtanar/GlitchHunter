using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    float xMoveFactor;
    float yMoveFactor;
    Rigidbody2D myRigidbody;
    Animator myAnimator;
    PlayerShooter arrow;

    void Awake()
    {
        arrow = GetComponent<PlayerShooter>();
    }

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        xMoveFactor = 2.9f;
        yMoveFactor = 1.75f;  
    }
    
    void WarpUp()
    {
        myRigidbody.transform.position = new Vector2 (transform.position.x, transform.position.y + yMoveFactor);
        myAnimator.SetBool("IsMoving", false);
    }

    void WarpDown()
    {
        myRigidbody.transform.position = new Vector2 (transform.position.x, transform.position.y - yMoveFactor);
        myAnimator.SetBool("IsMoving", false);
    }

    void WarpRight()
    {
        myRigidbody.transform.position = new Vector2 (transform.position.x + xMoveFactor, transform.position.y);
        myAnimator.SetBool("IsMoving", false);
    }

    void WarpLeft()
    {
        myRigidbody.transform.position = new Vector2 (transform.position.x - xMoveFactor, transform.position.y);
        myAnimator.SetBool("IsMoving", false);
    }

    void OnMoveUp()
    {
        if(myRigidbody.transform.position.y !< -2.62963)
        {
            myAnimator.SetBool("IsMoving", true);
            Invoke("WarpUp", .03f);
            //
        }
    }


    void OnMoveDown()
    {
        if(myRigidbody.transform.position.y !> -2.75)
        {
            myAnimator.SetBool("IsMoving", true);
            Invoke("WarpDown", .03f);
        }
    }

    void OnMoveRight()
    {
        if(myRigidbody.transform.position.x !< -2.746297)
        {
            myAnimator.SetBool("IsMoving", true);
            Invoke("WarpRight", .08f);
        }
    }

    void OnMoveLeft()
    {
        if(myRigidbody.transform.position.x !> -7.25)
        {
            myAnimator.SetBool("IsMoving", true);
            Invoke("WarpLeft", .08f);    
        }
    }

    //TestCode to show off animations
    void ResetStance()
    {
        myAnimator.SetBool("IsCannon", false);
        myAnimator.SetBool("IsSword", false);
        myAnimator.SetBool("IsShooting", false);
        myAnimator.SetBool("IsBow", false);
    }

    
    void OnSpell1()
    {
        // myAnimator.SetBool("IsShooting", false);
        // myAnimator.SetBool("IsSword", false);
        myAnimator.SetBool("IsCannon", true);
        Invoke("ResetStance", .6f);
    }

    void OnSpell2()
    {
        // myAnimator.SetBool("IsShooting", false);
        // myAnimator.SetBool("IsCannon", false);
        myAnimator.SetBool("IsSword", true);
        Invoke("ResetStance", .5f);
    }
    
    void OnShuffle()
    {
        myAnimator.SetBool("IsShooting", false);
        myAnimator.SetBool("IsCannon", false);
        myAnimator.SetBool("IsSword", false);
        myAnimator.SetBool("IsBow", false);
    }
}
