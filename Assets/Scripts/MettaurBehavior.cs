using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MettaurBehavior : MonoBehaviour
{
    float xMoveFactor;
    float yMoveFactor;
    Rigidbody2D myRigidbody;
    Animator myAnimator;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        xMoveFactor = 2.9f;
        yMoveFactor = 1.75f;  
    }
    void WarpUp()
    {
        if(myRigidbody.transform.position.y !< -2.62963 /* && */)
        {
            myRigidbody.transform.position = new Vector2 (transform.position.x, transform.position.y + yMoveFactor);
            myAnimator.SetBool("IsMoving", false);
        }
    }

    void WarpDown()
    {
        if(myRigidbody.transform.position.y !> -2.75 /* && */)
        {
            myRigidbody.transform.position = new Vector2 (transform.position.x, transform.position.y - yMoveFactor);
            myAnimator.SetBool("IsMoving", false);            
        }
    }


    void Update()
    {
        
    }

}
