using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour, IInteractable
{

    [SerializeField]
    private Sprite noteToShow;

    [SerializeField]
    private new SpriteRenderer renderer;

    [SerializeField]
    private bool dialogOnInteract = false;
    [SerializeField]
    private string dialogName;
    [SerializeField]
    private Dialogue dialog;

    public void Interact()
    {
        renderer.sprite = noteToShow;
        if (dialogOnInteract)
        {
            dialog.StartDialogueOnInteraction(dialogName);
        }
    }

    public string GetActionText()
    {
        return "Press 'space' to read note.";
    }
}
