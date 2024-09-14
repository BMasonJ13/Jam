using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Locomotion : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private new SpriteRenderer renderer;

    float horizontal;
    float vertical;

    public float speed = 20.0f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        bool isMoving = !(Mathf.Abs(horizontal) <= 0.1 && Mathf.Abs(vertical) <= 0.1f);

        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Horizontal", horizontal);
        animator.SetBool("isMoving", isMoving);

        if (horizontal < 0)
        {
            renderer.flipX = true;
        }
        else
        {
            renderer.flipX = false;
        }

    }

    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(horizontal, vertical).normalized * speed;
    }
}
