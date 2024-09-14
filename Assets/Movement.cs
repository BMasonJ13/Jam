using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;

    float horizontal;
    float vertical;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * speed;
        vertical = Input.GetAxis("Vertical") * speed;


        HandleAnimations();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical);
    }

    

    private void HandleAnimations()
    {
        if (horizontal > 0)
        {
            animator.SetBool("WalkingRight", true);
            spriteRenderer.flipX = false;
        }
        else if (horizontal < 0)
        {
            animator.SetBool("WalkingRight", true);
            spriteRenderer.flipX = true;
        }
        else
        {
            animator.SetBool("WalkingRight", false);
        }

        animator.SetBool("WalkingUp", vertical > 0);
        animator.SetBool("WalkingDown", vertical < 0);
        animator.SetBool("Idle", vertical == 0 && horizontal == 0);
    }
       
}
