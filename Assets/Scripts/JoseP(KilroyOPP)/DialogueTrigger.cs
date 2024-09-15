using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class DialogueTrigger : MonoBehaviour
{


    [SerializeField]
    private Dialogue dialogue;
    [SerializeField]
    private string dialogueName;
    private new Collider2D collider;

    private void Start()
    {
        collider = GetComponent<Collider2D>();

        if (!collider.isTrigger)
        {
            Debug.Log(transform.name + " was not set as isTrigger. It was performed automatically. Please consider doing it in inspector.");
            collider.isTrigger = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //May need to check player collision only.
        dialogue.StartDialogueOnInteraction(dialogueName);
        Destroy(this);
    }
}
