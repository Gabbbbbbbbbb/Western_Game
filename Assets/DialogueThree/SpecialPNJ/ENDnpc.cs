using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDnpc : MonoBehaviour
{
    public ENDtrig trigger;
    public float Interactions = 5;

    public ENDmanage Counting;

    private bool canDestroy = true;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            trigger.StartDialogue();

        }
    }

    public void Update()
    {
        if (Counting.NumberClickk >= Interactions && canDestroy == true)
        {
            
            canDestroy = false;
        }
    }
}
