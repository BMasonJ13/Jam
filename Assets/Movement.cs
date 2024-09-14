using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    float horizontal;
    float vertical;
    
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * speed;
        vertical = Input.GetAxisRaw("Vertical") * speed;


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
