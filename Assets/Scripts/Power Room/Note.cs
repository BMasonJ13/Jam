using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour, IInteractable
{

    [SerializeField]
    private Sprite noteToShow;

    [SerializeField]
    private new SpriteRenderer renderer;

    public void Interact()
    {
        renderer.sprite = noteToShow;
    }

    public string GetActionText()
    {
        return "Press 'space' to read note.";
    }
}
