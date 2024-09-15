using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyProjectile : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float bulletSpeed;
    [SerializeField] float timeToDestroy;
    public Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.velocity = dir * bulletSpeed;
    }

    private void Update()
    {
        Destroy(this.gameObject, timeToDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }

}
