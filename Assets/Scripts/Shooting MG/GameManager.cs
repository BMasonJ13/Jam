using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Dialogue dialogue;
    [SerializeField] string sceneName;
    [SerializeField] bool blockMovement;
    Movement movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = GameObject.Find("Player").GetComponent<Movement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogue.endOfDialogue || blockMovement)
        {
            movement.enabled = true;
        }
        else
        { 
            movement.enabled = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
