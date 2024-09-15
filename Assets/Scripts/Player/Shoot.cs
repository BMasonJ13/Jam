using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField]
    GameObject projectile;
    GameObject projectilePrefab;
    [SerializeField]
    float bulletSpeed;
    [SerializeField]
    float bulletRate;

    float bulletDelay;


    private void Update()
    {

        bulletDelay -= Time.deltaTime;

        if (bulletDelay > 0)
            return;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            projectilePrefab = Instantiate(projectile, transform.position, Quaternion.identity);
            projectilePrefab.GetComponent<EnergyProjectile>().dir = Vector2.left;
            bulletDelay = bulletRate;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            projectilePrefab = Instantiate(projectile, transform.position, Quaternion.identity);
            projectilePrefab.GetComponent<EnergyProjectile>().dir = Vector2.right;
            bulletDelay = bulletRate;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            projectilePrefab = Instantiate(projectile, transform.position, Quaternion.identity);
            projectilePrefab.GetComponent<EnergyProjectile>().dir = Vector2.up;
            bulletDelay = bulletRate;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            projectilePrefab = Instantiate(projectile, transform.position, Quaternion.identity);
            projectilePrefab.GetComponent<EnergyProjectile>().dir = Vector2.down;
            bulletDelay = bulletRate;
        }



    }
}
