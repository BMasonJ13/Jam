using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour, IInteractable
{
    [SerializeField]
    private SpriteRenderer top;
    [SerializeField]
    private SpriteRenderer bottom;
    [SerializeField]
    private Sprite topOpen;
    [SerializeField]
    private Sprite bottomOpen;

    [SerializeField]
    private EasterEggData data;

    [SerializeField]
    private FoundPanelController controller;

    public void Interact()
    {
        top.sprite = topOpen;
        bottom.sprite = bottomOpen;
        controller.Activate(data);
    }

    public string GetActionText()
    {
        return "Press 'space' to search locker.";
    }
}
