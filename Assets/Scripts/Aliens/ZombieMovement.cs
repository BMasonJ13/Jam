using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Rigidbody2D rb;
    public Vector2 direction;

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direction.x * speed * Time.deltaTime, direction.y * speed * Time.deltaTime);
    }

    private void Update()
    {
        animator.SetFloat("velX", rb.velocity.x);
        animator.SetFloat("velY", rb.velocity.y);
    }

}
