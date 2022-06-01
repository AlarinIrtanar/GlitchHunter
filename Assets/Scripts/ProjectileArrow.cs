using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileArrow : MonoBehaviour
{
    [SerializeField] float arrowSpeed = 50f;
    [SerializeField] public float arrowLifetime= 1f;
    Rigidbody2D myRigidBody;


    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myRigidBody.velocity = new Vector2 (arrowSpeed, 0f);
        Destroy(gameObject, arrowLifetime);

    }


    void Update()
    {
        // myRigidBody.velocity = new Vector2 (arrowSpeed, 0f);
        // Destroy(gameObject, arrowLifetime);  
    }

}
