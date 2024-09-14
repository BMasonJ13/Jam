using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Generator : MonoBehaviour, IInteractable
{

    [SerializeField]
    private LevelManager manager;

    [SerializeField]
    private Vector2Int matrixPosition;

    [SerializeField]
    private new Light2D light;

    [SerializeField]
    private BlinkingLights blinking;

    public void Interact()
    {
        manager.UpdateGenStatus(matrixPosition.x, matrixPosition.y);
    }

    public string GetActionText()
    {
        return "Press 'Space' to toggle generator.";
    }

    public void Toggle(bool b)
    {
        blinking.enabled = b;
        light.enabled = b;
    }
}
