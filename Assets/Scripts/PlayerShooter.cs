using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] GameObject arrowPrefab;
    [SerializeField] Transform ArrowSpawnPoint;
    
    [SerializeField] public float arrowLifetime= 1f;
    [SerializeField] float firingRate = .2f;

    Rigidbody2D myRigidbody;
    Animator myAnimator;
    PlayerShooter arrow;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    void OnFire(/*InputValue value*/)
    {
        if(ArrowSpawnPoint != null)
        {
            Instantiate(arrowPrefab, ArrowSpawnPoint.position, ArrowSpawnPoint.rotation);
            myAnimator.SetBool("IsBow", true);   
            Invoke("ResetStance", .6f);
        } 
    }

    void ResetStance()
    {
        myAnimator.SetBool("IsCannon", false);
        myAnimator.SetBool("IsSword", false);
        myAnimator.SetBool("IsShooting", false);
        myAnimator.SetBool("IsBow", false);
    }

}
