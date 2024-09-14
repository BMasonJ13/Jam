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
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.position += new Vector3(horizontal, vertical);
        HandleAnimations();
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
