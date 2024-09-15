using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider2D))]
public class SceneLoader : MonoBehaviour
{

    [SerializeField]
    private int levelIndex;
    private new BoxCollider2D collider;

    private void Start()
    {
        collider = GetComponent<BoxCollider2D>();

        if (!collider.isTrigger)
        {
            collider.isTrigger = true;
            Debug.Log("[Autoset collider to isTrigger please consider making the collider trigger in inspector.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals("Player"))
        SceneManager.LoadSceneAsync(levelIndex);
    }
}
