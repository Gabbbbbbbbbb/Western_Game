using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCnormal : MonoBehaviour
{
    public DialogueTrigger trigger;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            trigger.StartDialogue();
        }
    }
}
