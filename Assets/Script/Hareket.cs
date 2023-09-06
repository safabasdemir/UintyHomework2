using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    Animator animator;
    public Rigidbody rb;
    public float speed;
    Vector3 move = Vector3.zero;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("walk", true);
            move = new Vector3(0, 0, 1) * Time.deltaTime * speed;
            rb.MovePosition(transform.position + transform.TransformDirection(move));
        }
        else
        {
            animator.SetBool("walk", false);
        }
    }
}
