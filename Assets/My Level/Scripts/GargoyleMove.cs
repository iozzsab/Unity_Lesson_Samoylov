using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class GargoyleMove : MonoBehaviour

{
    
    public float Speed = 10f;
    public bool isGrounded;
    Vector3 m_Movement;
    
    void Start()
    {
        
    }
    private void OnCollisionEnter()
    {
        isGrounded = true;
    }

    
    void Update()
    {
       
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3 (0, 200, 0));
        }

    }
    void FixedUpdate()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        m_Movement.Set(moveHorizontal, 0f, moveVertical);
        m_Movement.Normalize();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * Speed * Time.fixedDeltaTime);
    }
    
}
