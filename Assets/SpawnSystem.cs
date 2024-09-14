using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    [SerializeField] Vector2 zombieMovingDir;
    [SerializeField] float frecuency;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnZombie", 5f, frecuency);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnZombie()
    {
        GameObject zombiePrefab = Instantiate(zombie, transform.position, Quaternion.identity);
        zombiePrefab.GetComponent<ZombieMovement>().direction = zombieMovingDir;
    }


}
