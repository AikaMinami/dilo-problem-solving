using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBall_Scnd : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float xForce;
    public float yForce;
   
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

        Debug.Log(4+6/5*2);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            rigidBody2D.velocity = new Vector2(0, yForce);
        } 
        else if(Input.GetKeyDown(KeyCode.S))
        {
            rigidBody2D.velocity = new Vector2(0, -yForce);
        } 
        if(Input.GetKeyDown(KeyCode.D))
        {
            rigidBody2D.velocity = new Vector2(xForce, 0);
        } 
        else if(Input.GetKeyDown(KeyCode.A))
        {
            rigidBody2D.velocity = new Vector2(-xForce, 0);
        } 
    }
}
