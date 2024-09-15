using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hit(int hitAmount)
    { 
        health -= hitAmount;
        if (health == 0)
        { 
            Destroy(gameObject);
        }
    }
}
