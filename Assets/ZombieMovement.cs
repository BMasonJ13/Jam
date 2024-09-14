using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rb;
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direction.x * speed * Time.deltaTime, direction.y * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
