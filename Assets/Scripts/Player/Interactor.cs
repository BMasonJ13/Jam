using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{

    [SerializeField]
    private LayerMask interactMask;

    // Update is called once per frame
    void Update()
    {
        IInteractable b = Physics2D.OverlapCircle(transform.position, 1, interactMask)?.GetComponent<IInteractable>();

        if(b != null && Input.GetKeyDown(KeyCode.Space))
        {
            b.Interact();
        }
    }
}
